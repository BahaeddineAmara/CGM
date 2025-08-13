using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Comptabilite
{
    public partial class RecetteFinanceForm : Form
    {
        public RecetteFinanceForm()
        {
            InitializeComponent();
            lblWelcome.Text = $"Bienvenue, {LoginForm.CurrentUserFullName}";
        }

        private void RecetteFinanceForm_Load(object sender, EventArgs e)
        {
            InitializeDateControls();
            LoadRecetteFinanceForCurrentMonth();
            ConfigureDataGridView();
        }

        private void InitializeDateControls()
        {
            cmbMois.Items.AddRange(new string[] {
                "Janvier", "Février", "Mars", "Avril", "Mai", "Juin",
                "Juillet", "Août", "Septembre", "Octobre", "Novembre", "Décembre"
            });

            numAnnee.Minimum = 2020;
            numAnnee.Maximum = 2050;
            numAnnee.Value = DateTime.Now.Year;

            cmbMois.SelectedIndex = DateTime.Now.Month - 1;
        }

        private void LoadRecetteFinanceForCurrentMonth()
        {
            int moisActuel = DateTime.Now.Month;
            int anneeActuelle = DateTime.Now.Year;
            LoadRecetteFinanceForMonth(moisActuel, anneeActuelle);
        }

        private void LoadRecetteFinanceForMonth(int mois, int annee)
        {
            string checkQuery = @"SELECT COUNT(*) FROM recette_finance rf
                          JOIN societes s ON rf.societe_id = s.id
                          WHERE rf.mois = @mois AND rf.annee = @annee 
                          AND s.type_tableau = 'recette_finance'";

            MySqlParameter[] checkParams = {
                new MySqlParameter("@mois", mois),
                new MySqlParameter("@annee", annee)
            };

            int count = Convert.ToInt32(DatabaseHelper.ExecuteScalar(checkQuery, checkParams));

            if (count == 0)
            {
                CreateMonthlyData(mois, annee);
            }

            string query = @"SELECT s.id, s.nom AS societe_nom, 
                    rf.document_etat, rf.saisie_etat, rf.declaration_etat, 
                    rf.montant, rf.paiement_etat, rf.date_paiement, rf.numero_recu, rf.recu_etat
                    FROM recette_finance rf
                    JOIN societes s ON rf.societe_id = s.id
                    WHERE rf.mois = @mois AND rf.annee = @annee 
                    AND s.type_tableau = 'recette_finance'";

            MySqlParameter[] parameters = {
                new MySqlParameter("@mois", mois),
                new MySqlParameter("@annee", annee)
            };

            DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);
            dataGridView.DataSource = dt;

            ConfigureDataGridView();
        }

        private void CreateMonthlyData(int mois, int annee)
        {
            try
            {
                string societesQuery = @"SELECT id FROM societes 
                                        WHERE type_tableau = 'recette_finance' 
                                        AND (inactive_since IS NULL OR inactive_since > CURDATE())";
                DataTable societes = DatabaseHelper.ExecuteQuery(societesQuery);

                foreach (DataRow row in societes.Rows)
                {
                    int societeId = Convert.ToInt32(row["id"]);

                    string insertQuery = @"INSERT INTO recette_finance 
                                 (societe_id, document_etat, saisie_etat, declaration_etat, 
                                  paiement_etat, recu_etat, last_modified_by, mois, annee)
                                 VALUES 
                                 (@societe_id, 'non_arrive', 'non_fait', 'non_fait', 
                                  'non_fait', 'non_recu', @user_id, @mois, @annee)";

                    MySqlParameter[] insertParams = {
                        new MySqlParameter("@societe_id", societeId),
                        new MySqlParameter("@user_id", LoginForm.CurrentUserId),
                        new MySqlParameter("@mois", mois),
                        new MySqlParameter("@annee", annee)
                    };

                    DatabaseHelper.ExecuteNonQuery(insertQuery, insertParams);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la création des données mensuelles: {ex.Message}",
                               "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbMois_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMois.SelectedIndex >= 0)
            {
                int mois = cmbMois.SelectedIndex + 1;
                int annee = (int)numAnnee.Value;
                LoadRecetteFinanceForMonth(mois, annee);
            }
        }

        private void numAnnee_ValueChanged(object sender, EventArgs e)
        {
            if (cmbMois.SelectedIndex >= 0)
            {
                int mois = cmbMois.SelectedIndex + 1;
                int annee = (int)numAnnee.Value;
                LoadRecetteFinanceForMonth(mois, annee);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (cmbMois.SelectedIndex >= 0)
            {
                int mois = cmbMois.SelectedIndex + 1;
                int annee = (int)numAnnee.Value;
                LoadRecetteFinanceForMonth(mois, annee);
            }
            else
            {
                LoadRecetteFinanceForCurrentMonth();
            }
        }

        private void ConfigureDataGridView()
        {
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (dataGridView.Columns.Contains("id"))
                dataGridView.Columns["id"].HeaderText = "ID";
            if (dataGridView.Columns.Contains("societe_nom"))
                dataGridView.Columns["societe_nom"].HeaderText = "Nom de la Société";
            if (dataGridView.Columns.Contains("saisie_etat"))
                dataGridView.Columns["saisie_etat"].HeaderText = "État Saisie";
            if (dataGridView.Columns.Contains("declaration_etat"))
                dataGridView.Columns["declaration_etat"].HeaderText = "État Déclaration";
            if (dataGridView.Columns.Contains("montant"))
                dataGridView.Columns["montant"].HeaderText = "Montant";
            if (dataGridView.Columns.Contains("date_paiement"))
                dataGridView.Columns["date_paiement"].HeaderText = "Date de Paiement";
            if (dataGridView.Columns.Contains("numero_recu"))
                dataGridView.Columns["numero_recu"].HeaderText = "Numéro Reçu";

            if (dataGridView.Columns.Contains("document_etat"))
                dataGridView.Columns["document_etat"].Visible = false;
            if (dataGridView.Columns.Contains("paiement_etat"))
                dataGridView.Columns["paiement_etat"].Visible = false;
            if (dataGridView.Columns.Contains("recu_etat"))
                dataGridView.Columns["recu_etat"].Visible = false;

            dataGridView.CellFormatting += (sender, e) =>
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewCell cell = dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    string columnName = dataGridView.Columns[e.ColumnIndex].Name;

                    Color backColor = Color.White;
                    Color foreColor = Color.Black;

                    switch (columnName)
                    {
                        case "id":
                        case "societe_nom":
                            string documentEtat = dataGridView.Rows[e.RowIndex].Cells["document_etat"].Value?.ToString() ?? "";
                            switch (documentEtat)
                            {
                                case "arrive":
                                    backColor = Color.LightGreen;
                                    break;
                                case "en_cours":
                                    backColor = Color.Orange;
                                    break;
                                case "non_arrive":
                                    backColor = Color.LightCoral;
                                    break;
                            }
                            break;

                        case "saisie_etat":
                            string saisieValue = cell.Value?.ToString() ?? "";
                            switch (saisieValue)
                            {
                                case "fait":
                                    backColor = Color.LightGreen;
                                    break;
                                case "en_cours":
                                    backColor = Color.Orange;
                                    break;
                                case "non_fait":
                                    backColor = Color.LightCoral;
                                    break;
                            }
                            break;

                        case "declaration_etat":
                            string declarationValue = cell.Value?.ToString() ?? "";
                            switch (declarationValue)
                            {
                                case "fait":
                                    backColor = Color.LightGreen;
                                    break;
                                case "en_cours":
                                    backColor = Color.Orange;
                                    break;
                                case "non_fait":
                                    backColor = Color.LightCoral;
                                    break;
                            }
                            break;

                        case "montant":
                        case "date_paiement":
                            string paiementEtat = dataGridView.Rows[e.RowIndex].Cells["paiement_etat"].Value?.ToString() ?? "";
                            switch (paiementEtat)
                            {
                                case "fait":
                                    backColor = Color.LightGreen;
                                    break;
                                case "en_cours":
                                    backColor = Color.Orange;
                                    break;
                                case "non_fait":
                                    backColor = Color.LightCoral;
                                    break;
                            }
                            break;

                        case "numero_recu":
                            string recuEtat = dataGridView.Rows[e.RowIndex].Cells["recu_etat"].Value?.ToString() ?? "";
                            switch (recuEtat)
                            {
                                case "recu":
                                    backColor = Color.LightGreen;
                                    break;
                                case "en_attente":
                                    backColor = Color.Orange;
                                    break;
                                case "non_recu":
                                    backColor = Color.LightCoral;
                                    break;
                            }
                            break;
                    }

                    cell.Style.BackColor = backColor;
                    cell.Style.ForeColor = foreColor;
                }
            };
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int societeId = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells["id"].Value);
                RecetteFinanceSocieteDetailForm detail = new RecetteFinanceSocieteDetailForm(societeId);
                detail.ShowDialog();

                if (cmbMois.SelectedIndex >= 0)
                {
                    int mois = cmbMois.SelectedIndex + 1;
                    int annee = (int)numAnnee.Value;
                    LoadRecetteFinanceForMonth(mois, annee);
                }
                else
                {
                    LoadRecetteFinanceForCurrentMonth();
                }
            }
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
} 