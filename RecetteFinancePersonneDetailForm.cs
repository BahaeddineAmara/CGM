using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Comptabilite
{
    public partial class RecetteFinancePersonneDetailForm : Form
    {
        private int personneId;
        private int currentMonth;
        private int currentYear;

        public RecetteFinancePersonneDetailForm(int personneId)
        {
            InitializeComponent();
            this.personneId = personneId;
            this.currentMonth = DateTime.Now.Month;
            this.currentYear = DateTime.Now.Year;
            LoadPersonneInfo();
            LoadRecetteFinanceData();
        }

        private void LoadPersonneInfo()
        {
            try
            {
                string query = "SELECT nom FROM personnes WHERE id = @personneId";
                MySqlParameter[] parameters = { new MySqlParameter("@personneId", personneId) };
                DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);

                if (dt.Rows.Count > 0)
                {
                    string nomPersonne = dt.Rows[0]["nom"].ToString();
                    this.Text = $"Détails Recette Finance - {nomPersonne}";
                    lblPersonneNom.Text = nomPersonne;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des informations de la personne: {ex.Message}",
                               "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadRecetteFinanceData()
        {
            try
            {
                string query = @"SELECT document_etat, saisie_etat, declaration_etat, montant, 
                                paiement_etat, date_paiement, numero_recu, recu_etat
                                FROM recette_finance_personnes 
                                WHERE personne_id = @personneId AND mois = @mois AND annee = @annee";

                MySqlParameter[] parameters = {
                    new MySqlParameter("@personneId", personneId),
                    new MySqlParameter("@mois", currentMonth),
                    new MySqlParameter("@annee", currentYear)
                };

                DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    
                    // Document état
                    switch (row["document_etat"].ToString())
                    {
                        case "arrive": rbDocumentArrive.Checked = true; break;
                        case "en_cours": rbDocumentEnCours.Checked = true; break;
                        case "non_arrive": rbDocumentNonArrive.Checked = true; break;
                    }

                    // Saisie état
                    switch (row["saisie_etat"].ToString())
                    {
                        case "fait": rbSaisieFait.Checked = true; break;
                        case "en_cours": rbSaisieEnCours.Checked = true; break;
                        case "non_fait": rbSaisieNonFait.Checked = true; break;
                    }

                    // Déclaration état
                    switch (row["declaration_etat"].ToString())
                    {
                        case "fait": rbDeclarationFait.Checked = true; break;
                        case "en_cours": rbDeclarationEnCours.Checked = true; break;
                        case "non_fait": rbDeclarationNonFait.Checked = true; break;
                    }

                    // Montant
                    if (row["montant"] != DBNull.Value)
                    {
                        numMontant.Value = Convert.ToDecimal(row["montant"]);
                    }

                    // Paiement état
                    switch (row["paiement_etat"].ToString())
                    {
                        case "fait": rbPaiementFait.Checked = true; break;
                        case "en_cours": rbPaiementEnCours.Checked = true; break;
                        case "non_fait": rbPaiementNonFait.Checked = true; break;
                    }

                    // Date de paiement
                    if (row["date_paiement"] != DBNull.Value)
                    {
                        dtpDatePaiement.Value = Convert.ToDateTime(row["date_paiement"]);
                        chkDatePaiement.Checked = true;
                    }

                    // Numéro reçu
                    txtNumeroRecu.Text = row["numero_recu"]?.ToString() ?? "";

                    // Reçu état
                    switch (row["recu_etat"].ToString())
                    {
                        case "recu": rbRecuRecu.Checked = true; break;
                        case "en_attente": rbRecuEnAttente.Checked = true; break;
                        case "non_recu": rbRecuNonRecu.Checked = true; break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des données: {ex.Message}",
                               "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string documentEtat = GetDocumentEtat();
                string saisieEtat = GetSaisieEtat();
                string declarationEtat = GetDeclarationEtat();
                string paiementEtat = GetPaiementEtat();
                string recuEtat = GetRecuEtat();

                decimal? montant = null;
                if (numMontant.Value > 0)
                {
                    montant = numMontant.Value;
                }

                DateTime? datePaiement = null;
                if (chkDatePaiement.Checked)
                {
                    datePaiement = dtpDatePaiement.Value;
                }

                string numeroRecu = txtNumeroRecu.Text.Trim();

                string query = @"UPDATE recette_finance_personnes 
                                SET document_etat = @document_etat, 
                                    saisie_etat = @saisie_etat, 
                                    declaration_etat = @declaration_etat, 
                                    montant = @montant, 
                                    paiement_etat = @paiement_etat, 
                                    date_paiement = @date_paiement, 
                                    numero_recu = @numero_recu, 
                                    recu_etat = @recu_etat, 
                                    last_modified_by = @user_id, 
                                    last_modified_date = NOW()
                                WHERE personne_id = @personne_id AND mois = @mois AND annee = @annee";

                MySqlParameter[] parameters = {
                    new MySqlParameter("@document_etat", documentEtat),
                    new MySqlParameter("@saisie_etat", saisieEtat),
                    new MySqlParameter("@declaration_etat", declarationEtat),
                    new MySqlParameter("@montant", montant),
                    new MySqlParameter("@paiement_etat", paiementEtat),
                    new MySqlParameter("@date_paiement", datePaiement),
                    new MySqlParameter("@numero_recu", numeroRecu),
                    new MySqlParameter("@recu_etat", recuEtat),
                    new MySqlParameter("@user_id", LoginForm.CurrentUserId),
                    new MySqlParameter("@personne_id", personneId),
                    new MySqlParameter("@mois", currentMonth),
                    new MySqlParameter("@annee", currentYear)
                };

                DatabaseHelper.ExecuteNonQuery(query, parameters);

                MessageBox.Show("Données mises à jour avec succès!", "Succès", 
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la sauvegarde: {ex.Message}",
                               "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetDocumentEtat()
        {
            if (rbDocumentArrive.Checked) return "arrive";
            if (rbDocumentEnCours.Checked) return "en_cours";
            return "non_arrive";
        }

        private string GetSaisieEtat()
        {
            if (rbSaisieFait.Checked) return "fait";
            if (rbSaisieEnCours.Checked) return "en_cours";
            return "non_fait";
        }

        private string GetDeclarationEtat()
        {
            if (rbDeclarationFait.Checked) return "fait";
            if (rbDeclarationEnCours.Checked) return "en_cours";
            return "non_fait";
        }

        private string GetPaiementEtat()
        {
            if (rbPaiementFait.Checked) return "fait";
            if (rbPaiementEnCours.Checked) return "en_cours";
            return "non_fait";
        }

        private string GetRecuEtat()
        {
            if (rbRecuRecu.Checked) return "recu";
            if (rbRecuEnAttente.Checked) return "en_attente";
            return "non_recu";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void chkDatePaiement_CheckedChanged(object sender, EventArgs e)
        {
            dtpDatePaiement.Enabled = chkDatePaiement.Checked;
        }
    }
} 