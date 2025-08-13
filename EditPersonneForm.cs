using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Comptabilite
{
    public partial class EditPersonneForm : Form
    {
        private int personneId;

        public EditPersonneForm(int id)
        {
            InitializeComponent();
            personneId = id;
            InitializeTypeTableauComboBox();
            LoadPersonneData();
        }

        private void InitializeTypeTableauComboBox()
        {
            cmbTypeTableau.Items.Clear();
            cmbTypeTableau.Items.AddRange(new string[] {
                "Télédéclaration",
                "Téléliquidation", 
                "Référence Financière"
            });
        }

        private void LoadPersonneData()
        {
            try
            {
                string query = "SELECT nom, adresse, numero_telephone, email, code_tva, nature_contrat, type_tableau FROM personnes WHERE id = @id";
                MySqlParameter[] parameters = { new MySqlParameter("@id", personneId) };
                DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    txtNom.Text = row["nom"].ToString();
                    txtAdresse.Text = row["adresse"]?.ToString() ?? "";
                    txtTelephone.Text = row["numero_telephone"]?.ToString() ?? "";
                    txtEmail.Text = row["email"]?.ToString() ?? "";
                    txtCodeTVA.Text = row["code_tva"]?.ToString() ?? "";
                    txtNatureContrat.Text = row["nature_contrat"]?.ToString() ?? "";

                    // Sélectionner le type de tableau
                    string typeTableau = row["type_tableau"]?.ToString() ?? "teledeclaration";
                    switch (typeTableau)
                    {
                        case "teledeclaration":
                            cmbTypeTableau.SelectedIndex = 0;
                            break;
                        case "teleliquidation":
                            cmbTypeTableau.SelectedIndex = 1;
                            break;
                        case "reference_financiere":
                            cmbTypeTableau.SelectedIndex = 2;
                            break;
                        default:
                            cmbTypeTableau.SelectedIndex = 0;
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des données: {ex.Message}", 
                               "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtNom.Text))
            {
                MessageBox.Show("Le nom est obligatoire.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNom.Focus();
                return false;
            }

            if (!string.IsNullOrWhiteSpace(txtEmail.Text) && !IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Veuillez entrer une adresse email valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return false;
            }

            return true;
        }

        private void SavePersonne()
        {
            try
            {
                string query = @"UPDATE personnes 
                                SET nom = @nom, adresse = @adresse, numero_telephone = @telephone, 
                                    email = @email, code_tva = @code_tva, nature_contrat = @nature_contrat, 
                                    type_tableau = @type_tableau
                                WHERE id = @id";

                MySqlParameter[] parameters = {
                    new MySqlParameter("@nom", txtNom.Text.Trim()),
                    new MySqlParameter("@adresse", string.IsNullOrWhiteSpace(txtAdresse.Text) ? DBNull.Value : (object)txtAdresse.Text.Trim()),
                    new MySqlParameter("@telephone", string.IsNullOrWhiteSpace(txtTelephone.Text) ? DBNull.Value : (object)txtTelephone.Text.Trim()),
                    new MySqlParameter("@email", string.IsNullOrWhiteSpace(txtEmail.Text) ? DBNull.Value : (object)txtEmail.Text.Trim()),
                    new MySqlParameter("@code_tva", string.IsNullOrWhiteSpace(txtCodeTVA.Text) ? DBNull.Value : (object)txtCodeTVA.Text.Trim()),
                    new MySqlParameter("@nature_contrat", string.IsNullOrWhiteSpace(txtNatureContrat.Text) ? DBNull.Value : (object)txtNatureContrat.Text.Trim()),
                    new MySqlParameter("@type_tableau", GetTypeTableauValue()),
                    new MySqlParameter("@id", personneId)
                };

                DatabaseHelper.ExecuteNonQuery(query, parameters);

                MessageBox.Show("Personne modifiée avec succès!", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la modification: {ex.Message}", 
                               "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                SavePersonne();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

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