using MySql.Data.MySqlClient;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Comptabilite
{
    public partial class AddSocieteForm : Form
    {
        public AddSocieteForm()
        {
            InitializeComponent();
            InitializeTypeTableauComboBox();
        }

        private void InitializeTypeTableauComboBox()
        {
            cmbTypeTableau.Items.Clear();
            cmbTypeTableau.Items.AddRange(new string[] {
                "Télédéclaration",
                "Téléliquidation", 
                "Recette Finance"
            });
            cmbTypeTableau.SelectedIndex = 0; // Par défaut: Télédéclaration
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validation de l'ID
            string idText = txtId.Text.Trim();
            if (string.IsNullOrEmpty(idText))
            {
                MessageBox.Show("Veuillez entrer un ID", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtId.Focus();
                return;
            }

            if (!int.TryParse(idText, out int societeId) || societeId <= 0)
            {
                MessageBox.Show("L'ID doit être un nombre entier positif", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtId.Focus();
                return;
            }

            // Vérifier si l'ID existe déjà
            if (IdExists(societeId))
            {
                MessageBox.Show("Cet ID existe déjà. Veuillez choisir un autre ID.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtId.Focus();
                return;
            }

            // Validation des champs obligatoires
            string nomSociete = txtNomSociete.Text.Trim();
            if (string.IsNullOrEmpty(nomSociete))
            {
                MessageBox.Show("Veuillez entrer un nom de société", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNomSociete.Focus();
                return;
            }

            // Validation de l'email si fourni
            string email = txtEmail.Text.Trim();
            if (!string.IsNullOrEmpty(email) && !IsValidEmail(email))
            {
                MessageBox.Show("Veuillez entrer une adresse email valide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }

            // Validation du téléphone si fourni (format simple)
            string telephone = txtTelephone.Text.Trim();
            if (!string.IsNullOrEmpty(telephone) && !IsValidPhoneNumber(telephone))
            {
                MessageBox.Show("Veuillez entrer un numéro de téléphone valide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTelephone.Focus();
                return;
            }

            try
            {
                // Récupération de toutes les valeurs
                string adresse = txtAdresse.Text.Trim();
                string codeTVA = txtCodeTVA.Text.Trim();
                string natureContrat = txtNatureContrat.Text.Trim();
                
                // Récupération du type de tableau
                string typeTableau = GetTypeTableauValue();

                // Insert societe avec tous les champs
                string query = @"INSERT INTO societes (id, nom, adresse, numero_telephone, email, code_tva, nature_contrat, type_tableau, active_since) 
                                VALUES (@id, @nom, @adresse, @telephone, @email, @codeTVA, @natureContrat, @typeTableau, CURDATE())";

                MySqlParameter[] parameters = {
                    new MySqlParameter("@id", societeId),
                    new MySqlParameter("@nom", nomSociete),
                    new MySqlParameter("@adresse", string.IsNullOrEmpty(adresse) ? (object)DBNull.Value : adresse),
                    new MySqlParameter("@telephone", string.IsNullOrEmpty(telephone) ? (object)DBNull.Value : telephone),
                    new MySqlParameter("@email", string.IsNullOrEmpty(email) ? (object)DBNull.Value : email),
                    new MySqlParameter("@codeTVA", string.IsNullOrEmpty(codeTVA) ? (object)DBNull.Value : codeTVA),
                    new MySqlParameter("@natureContrat", string.IsNullOrEmpty(natureContrat) ? (object)DBNull.Value : natureContrat),
                    new MySqlParameter("@typeTableau", typeTableau)
                };

                DatabaseHelper.ExecuteNonQuery(query, parameters);

                // Insert default teledeclaration pour le mois actuel SEULEMENT si le type est teledeclaration
                if (typeTableau == "teledeclaration")
                {
                    int moisActuel = DateTime.Now.Month;
                    int anneeActuelle = DateTime.Now.Year;

                    query = @"INSERT INTO teledeclaration 
                            (societe_id, document_etat, saisie_etat, declaration_etat, 
                             paiement_etat, quittance_etat, last_modified_by, mois, annee)
                            VALUES 
                            (@societe_id, 'non_arrive', 'non_fait', 'non_fait', 
                             'non_fait', 'non_recu', @user_id, @mois, @annee)";

                    MySqlParameter[] teledeclarationParams = {
                        new MySqlParameter("@societe_id", societeId),
                        new MySqlParameter("@user_id", LoginForm.CurrentUserId),
                        new MySqlParameter("@mois", moisActuel),
                        new MySqlParameter("@annee", anneeActuelle)
                    };

                    DatabaseHelper.ExecuteNonQuery(query, teledeclarationParams);
                }

                MessageBox.Show("Société ajoutée avec succès!", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'ajout de la société: {ex.Message}", 
                               "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        // Méthode pour vérifier si l'ID existe déjà
        private bool IdExists(int id)
        {
            try
            {
                string query = "SELECT COUNT(*) FROM societes WHERE id = @id";
                MySqlParameter[] parameters = {  // Changed to array
            new MySqlParameter("@id", id)
        };
                object result = DatabaseHelper.ExecuteScalar(query, parameters);
                return Convert.ToInt32(result) > 0;
            }
            catch
            {
                // En cas d'erreur, considérer que l'ID existe pour éviter les doublons
                return true;
            }
        }

        // Validation de l'email
        private bool IsValidEmail(string email)
        {
            try
            {
                var regex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
                return regex.IsMatch(email);
            }
            catch
            {
                return false;
            }
        }

        // Validation du numéro de téléphone (format simple)
        private bool IsValidPhoneNumber(string phone)
        {
            try
            {
                // Accepte les chiffres, espaces, tirets, parenthèses et le signe +
                var regex = new Regex(@"^[\+]?[\d\s\-\(\)]{8,20}$");
                return regex.IsMatch(phone);
            }
            catch
            {
                return false;
            }
        }

        private string GetTypeTableauValue()
        {
            switch (cmbTypeTableau.SelectedIndex)
            {
                case 0: return "teledeclaration";
                case 1: return "teleliquidation";
                case 2: return "recette_finance";
                default: return "teledeclaration";
            }
        }
    }
}