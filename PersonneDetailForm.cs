using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Comptabilite
{
    public partial class PersonneDetailForm : Form
    {
        private int teleDeclarationId;
        private int personneId;
        private string personneName;

        public PersonneDetailForm(int personneId)
        {
            InitializeComponent();
            this.personneId = personneId;
        }

        private void PersonneDetailForm_Load(object sender, EventArgs e)
        {
            LoadTeleDeclarationData();
            lblPersonneName.Text = $"Personne: {personneName}";
        }

        private void LoadTeleDeclarationData()
        {
            // On charge la teledeclaration du mois/année en cours pour cette personne
            int mois = DateTime.Now.Month;
            int annee = DateTime.Now.Year;
            string query = @"SELECT tdp.*, p.nom AS personne_nom 
                            FROM teledeclaration_personnes tdp
                            JOIN personnes p ON tdp.personne_id = p.id
                            WHERE tdp.personne_id = @personneId AND tdp.mois = @mois AND tdp.annee = @annee";
            MySqlParameter[] parameters = {
                new MySqlParameter("@personneId", personneId),
                new MySqlParameter("@mois", mois),
                new MySqlParameter("@annee", annee)
            };
            DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                personneName = row["personne_nom"].ToString();

                // Document state
                switch (row["document_etat"].ToString())
                {
                    case "arrive":
                        rdbDocArrive.Checked = true;
                        break;
                    case "en_cours":
                        rdbDocEnCours.Checked = true;
                        break;
                    case "non_arrive":
                        rdbDocNonArrive.Checked = true;
                        break;
                }

                // Saisie state
                switch (row["saisie_etat"].ToString())
                {
                    case "fait":
                        rdbSaisieFait.Checked = true;
                        break;
                    case "en_cours":
                        rdbSaisieEnCours.Checked = true;
                        break;
                    case "non_fait":
                        rdbSaisieNonFait.Checked = true;
                        break;
                }

                // Declaration state
                switch (row["declaration_etat"].ToString())
                {
                    case "fait":
                        rdbDeclarationFait.Checked = true;
                        break;
                    case "en_cours":
                        rdbDeclarationEnCours.Checked = true;
                        break;
                    case "non_fait":
                        rdbDeclarationNonFait.Checked = true;
                        break;
                }

                // Paiement state
                switch (row["paiement_etat"].ToString())
                {
                    case "fait":
                        rdbPaiementFait.Checked = true;
                        break;
                    case "en_cours":
                        rdbPaiementEnCours.Checked = true;
                        break;
                    case "non_fait":
                        rdbPaiementNonFait.Checked = true;
                        break;
                }

                txtBanque.Text = row["banque"]?.ToString() ?? "";
                txtMontant.Text = row["montant"]?.ToString() ?? "";

                // Quittance state
                switch (row["quittance_etat"].ToString())
                {
                    case "recu":
                        rdbQuittanceRecu.Checked = true;
                        break;
                    case "en_attente":
                        rdbQuittanceEnAttente.Checked = true;
                        break;
                    case "non_recu":
                        rdbQuittanceNonRecu.Checked = true;
                        break;
                }

                txtQuittanceNumero.Text = row["quittance_numero"]?.ToString() ?? "";
            }
        }

        private string GetSelectedState(RadioButton selectedButton, string prefix)
        {
            if (selectedButton == null) return "non_fait"; // ou la valeur par défaut appropriée

            string buttonText = selectedButton.Text.ToLower();

            switch (prefix)
            {
                case "document":
                    if (buttonText.Contains("arrivé") || buttonText.Contains("arrive"))
                        return "arrive";
                    else if (buttonText.Contains("en cours"))
                        return "en_cours";
                    else
                        return "non_arrive";

                case "saisie":
                case "declaration":
                case "paiement":
                    if (buttonText.Contains("fait"))
                        return "fait";
                    else if (buttonText.Contains("en cours"))
                        return "en_cours";
                    else
                        return "non_fait";

                case "quittance":
                    if (buttonText.Contains("reçu") || buttonText.Contains("recu"))
                        return "recu";
                    else if (buttonText.Contains("en attente"))
                        return "en_attente";
                    else
                        return "non_recu";

                default:
                    return "non_fait";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Déterminer l'état du document
                RadioButton selectedDocButton = rdbDocArrive.Checked ? rdbDocArrive :
                                               rdbDocEnCours.Checked ? rdbDocEnCours : rdbDocNonArrive;
                string documentEtat = GetSelectedState(selectedDocButton, "document");

                // Déterminer l'état de saisie
                RadioButton selectedSaisieButton = rdbSaisieFait.Checked ? rdbSaisieFait :
                                                  rdbSaisieEnCours.Checked ? rdbSaisieEnCours : rdbSaisieNonFait;
                string saisieEtat = GetSelectedState(selectedSaisieButton, "saisie");

                // Déterminer l'état de déclaration
                RadioButton selectedDeclarationButton = rdbDeclarationFait.Checked ? rdbDeclarationFait :
                                                       rdbDeclarationEnCours.Checked ? rdbDeclarationEnCours : rdbDeclarationNonFait;
                string declarationEtat = GetSelectedState(selectedDeclarationButton, "declaration");

                // Déterminer l'état de paiement
                RadioButton selectedPaiementButton = rdbPaiementFait.Checked ? rdbPaiementFait :
                                                    rdbPaiementEnCours.Checked ? rdbPaiementEnCours : rdbPaiementNonFait;
                string paiementEtat = GetSelectedState(selectedPaiementButton, "paiement");

                // Déterminer l'état de quittance
                RadioButton selectedQuittanceButton = rdbQuittanceRecu.Checked ? rdbQuittanceRecu :
                                                     rdbQuittanceEnAttente.Checked ? rdbQuittanceEnAttente : rdbQuittanceNonRecu;
                string quittanceEtat = GetSelectedState(selectedQuittanceButton, "quittance");

                float montant = 0;
                float.TryParse(txtMontant.Text, out montant);

                int mois = DateTime.Now.Month;
                int annee = DateTime.Now.Year;

                string query = @"UPDATE teledeclaration_personnes SET 
                        document_etat = @document_etat,
                        saisie_etat = @saisie_etat,
                        declaration_etat = @declaration_etat,
                        montant = @montant,
                        banque = @banque,
                        paiement_etat = @paiement_etat,
                        quittance_numero = @quittance_numero,
                        quittance_etat = @quittance_etat,
                        last_modified_by = @user_id
                        WHERE personne_id = @personne_id AND mois = @mois AND annee = @annee";

                MySqlParameter[] parameters = {
            new MySqlParameter("@document_etat", documentEtat),
            new MySqlParameter("@saisie_etat", saisieEtat),
            new MySqlParameter("@declaration_etat", declarationEtat),
            new MySqlParameter("@montant", montant),
            new MySqlParameter("@banque", txtBanque.Text),
            new MySqlParameter("@paiement_etat", paiementEtat),
            new MySqlParameter("@quittance_numero", txtQuittanceNumero.Text),
            new MySqlParameter("@quittance_etat", quittanceEtat),
            new MySqlParameter("@user_id", LoginForm.CurrentUserId),
            new MySqlParameter("@personne_id", personneId),
            new MySqlParameter("@mois", mois),
            new MySqlParameter("@annee", annee)
        };

                int rowsAffected = DatabaseHelper.ExecuteNonQuery(query, parameters);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Modifications enregistrées avec succès", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Aucune modification n'a été enregistrée", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'enregistrement: {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void rdbPaiementFait_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbPaiementFait.Checked)
            {
                txtBanque.Enabled = true;
                txtMontant.Enabled = true;
            }
        }

        private void rdbPaiementEnCours_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbPaiementEnCours.Checked)
            {
                txtBanque.Enabled = true;
                txtMontant.Enabled = true;
            }
        }

        private void rdbPaiementNonFait_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbPaiementNonFait.Checked)
            {
                txtBanque.Enabled = false;
                txtMontant.Enabled = false;
            }
        }

        private void rdbQuittanceRecu_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbQuittanceRecu.Checked)
            {
                txtQuittanceNumero.Enabled = true;
            }
        }

        private void rdbQuittanceEnAttente_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbQuittanceEnAttente.Checked)
            {
                txtQuittanceNumero.Enabled = false;
            }
        }

        private void rdbQuittanceNonRecu_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbQuittanceNonRecu.Checked)
            {
                txtQuittanceNumero.Enabled = false;
            }
        }
    }
} 