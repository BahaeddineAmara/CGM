using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Comptabilite
{
    public partial class EditSocieteForm : Form
    {
        private int societeId;

        public EditSocieteForm(int id)
        {
            InitializeComponent();
            societeId = id;
            InitializeTypeTableauComboBox();
            LoadSocieteData();
        }

        private void InitializeTypeTableauComboBox()
        {
            cmbTypeTableau.Items.Clear();
            cmbTypeTableau.Items.AddRange(new string[] {
                "Télédéclaration",
                "Téléliquidation", 
                "Recette Finance"
            });
        }

        private void LoadSocieteData()
        {
            try
            {
                string query = "SELECT nom, adresse, numero_telephone, email, code_tva, nature_contrat, type_tableau FROM societes WHERE id = @id";
                MySqlParameter[] parameters = { new MySqlParameter("@id", societeId) };
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
                    
                    // Charger le type de tableau
                    string typeTableau = row["type_tableau"]?.ToString() ?? "teledeclaration";
                    SetTypeTableauSelection(typeTableau);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des données: {ex.Message}", 
                               "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetTypeTableauSelection(string typeTableau)
        {
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                SaveSociete();
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtNom.Text))
            {
                MessageBox.Show("Le nom de la société est obligatoire.", 
                               "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNom.Focus();
                return false;
            }

            if (!string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                try
                {
                    var addr = new System.Net.Mail.MailAddress(txtEmail.Text);
                }
                catch
                {
                    MessageBox.Show("L'adresse email n'est pas valide.", 
                                   "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEmail.Focus();
                    return false;
                }
            }

            return true;
        }

        private void SaveSociete()
        {
            try
            {
                string typeTableau = GetTypeTableauValue();
                
                string query = @"UPDATE societes 
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
                    new MySqlParameter("@type_tableau", typeTableau),
                    new MySqlParameter("@id", societeId)
                };

                DatabaseHelper.ExecuteNonQuery(query, parameters);

                MessageBox.Show("Société modifiée avec succès.", 
                               "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la modification: {ex.Message}", 
                               "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
} 