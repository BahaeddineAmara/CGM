using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Comptabilite
{
    public partial class TeleliquidationSocieteDetailForm : Form
    {
        private int societeId;
        private string societeName;

        public TeleliquidationSocieteDetailForm(int societeId)
        {
            InitializeComponent();
            this.societeId = societeId;
        }

        private void TeleliquidationSocieteDetailForm_Load(object sender, EventArgs e)
        {
            LoadData();
            lblSocieteName.Text = $"Société: {societeName}";
        }

        private void LoadData()
        {
            int mois = DateTime.Now.Month;
            int annee = DateTime.Now.Year;
            string query = @"SELECT tl.*, s.nom AS societe_nom 
                            FROM teleliquidation tl
                            JOIN societes s ON tl.societe_id = s.id
                            WHERE tl.societe_id = @societeId AND tl.mois = @mois AND tl.annee = @annee";
            var parameters = new MySqlParameter[] {
                new MySqlParameter("@societeId", societeId),
                new MySqlParameter("@mois", mois),
                new MySqlParameter("@annee", annee)
            };
            DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                societeName = row["societe_nom"].ToString();
                switch (row["document_etat"].ToString())
                {
                    case "arrive": rdbDocArrive.Checked = true; break;
                    case "en_cours": rdbDocEnCours.Checked = true; break;
                    case "non_arrive": rdbDocNonArrive.Checked = true; break;
                }
                switch (row["saisie_etat"].ToString())
                {
                    case "fait": rdbSaisieFait.Checked = true; break;
                    case "en_cours": rdbSaisieEnCours.Checked = true; break;
                    case "non_fait": rdbSaisieNonFait.Checked = true; break;
                }
                switch (row["declaration_etat"].ToString())
                {
                    case "fait": rdbDeclarationFait.Checked = true; break;
                    case "en_cours": rdbDeclarationEnCours.Checked = true; break;
                    case "non_fait": rdbDeclarationNonFait.Checked = true; break;
                }
                switch (row["paiement_etat"].ToString())
                {
                    case "fait": rdbPaiementFait.Checked = true; break;
                    case "en_cours": rdbPaiementEnCours.Checked = true; break;
                    case "non_fait": rdbPaiementNonFait.Checked = true; break;
                }
                switch (row["recu_etat"].ToString())
                {
                    case "recu": rdbRecu.Checked = true; break;
                    case "en_attente": rdbRecuEnAttente.Checked = true; break;
                    case "non_recu": rdbRecuNonRecu.Checked = true; break;
                }
                txtNumeroRecu.Text = row["numero_recu"]?.ToString() ?? "";
                txtMontant.Text = row["montant"]?.ToString() ?? "";
            }
        }

        private string MapState(RadioButton selected, string type)
        {
            if (selected == null) return type == "document" ? "non_arrive" : type == "recu" ? "non_recu" : "non_fait";
            string text = selected.Text.ToLower();
            if (type == "document") return text.Contains("arriv") ? "arrive" : text.Contains("en cours") ? "en_cours" : "non_arrive";
            if (type == "recu") return text.Contains("reçu") || text.Contains("recu") ? "recu" : text.Contains("attente") ? "en_attente" : "non_recu";
            return text.Contains("fait") ? "fait" : text.Contains("en cours") ? "en_cours" : "non_fait";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string documentEtat = MapState(rdbDocArrive.Checked ? rdbDocArrive : rdbDocEnCours.Checked ? rdbDocEnCours : rdbDocNonArrive, "document");
                string saisieEtat = MapState(rdbSaisieFait.Checked ? rdbSaisieFait : rdbSaisieEnCours.Checked ? rdbSaisieEnCours : rdbSaisieNonFait, "saisie");
                string declarationEtat = MapState(rdbDeclarationFait.Checked ? rdbDeclarationFait : rdbDeclarationEnCours.Checked ? rdbDeclarationEnCours : rdbDeclarationNonFait, "declaration");
                string paiementEtat = MapState(rdbPaiementFait.Checked ? rdbPaiementFait : rdbPaiementEnCours.Checked ? rdbPaiementEnCours : rdbPaiementNonFait, "paiement");
                string recuEtat = MapState(rdbRecu.Checked ? rdbRecu : rdbRecuEnAttente.Checked ? rdbRecuEnAttente : rdbRecuNonRecu, "recu");

                float montantVal = 0; float.TryParse(txtMontant.Text, out montantVal);
                int mois = DateTime.Now.Month; int annee = DateTime.Now.Year;

                string query = @"UPDATE teleliquidation SET 
                                document_etat=@document_etat,
                                saisie_etat=@saisie_etat,
                                declaration_etat=@declaration_etat,
                                montant=@montant,
                                paiement_etat=@paiement_etat,
                                numero_recu=@numero_recu,
                                recu_etat=@recu_etat,
                                last_modified_by=@user_id
                                WHERE societe_id=@societe_id AND mois=@mois AND annee=@annee";
                var parameters = new MySqlParameter[] {
                    new MySqlParameter("@document_etat", documentEtat),
                    new MySqlParameter("@saisie_etat", saisieEtat),
                    new MySqlParameter("@declaration_etat", declarationEtat),
                    new MySqlParameter("@montant", montantVal),
                    new MySqlParameter("@paiement_etat", paiementEtat),
                    new MySqlParameter("@numero_recu", txtNumeroRecu.Text),
                    new MySqlParameter("@recu_etat", recuEtat),
                    new MySqlParameter("@user_id", LoginForm.CurrentUserId),
                    new MySqlParameter("@societe_id", societeId),
                    new MySqlParameter("@mois", mois),
                    new MySqlParameter("@annee", annee)
                };

                int rows = DatabaseHelper.ExecuteNonQuery(query, parameters);
                if (rows > 0)
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
    }
}