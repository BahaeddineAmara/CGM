using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Comptabilite
{
    public partial class TeleliquidationPersonnesForm : Form
    {
        public TeleliquidationPersonnesForm()
        {
            InitializeComponent();
            lblWelcome.Text = $"Bienvenue, {LoginForm.CurrentUserFullName}";
        }

        private void TeleliquidationPersonnesForm_Load(object sender, EventArgs e)
        {
            InitializeDateControls();
            LoadTeleLiquidationsForCurrentMonth();
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

        private void LoadTeleLiquidationsForCurrentMonth()
        {
            int moisActuel = DateTime.Now.Month;
            int anneeActuelle = DateTime.Now.Year;
            LoadTeleLiquidationsForMonth(moisActuel, anneeActuelle);
        }

        private void LoadTeleLiquidationsForMonth(int mois, int annee)
        {
            string checkQuery = @"SELECT COUNT(*) FROM teleliquidation_personnes t
                             JOIN personnes p ON t.personne_id = p.id
                             WHERE t.mois = @mois AND t.annee = @annee 
                             AND p.type_tableau = 'teleliquidation'";
            var checkParams = new MySqlParameter[] {
                new MySqlParameter("@mois", mois),
                new MySqlParameter("@annee", annee)
            };
            int count = Convert.ToInt32(DatabaseHelper.ExecuteScalar(checkQuery, checkParams));
            if (count == 0)
            {
                CreateMonthlyData(mois, annee);
            }

            string query = @"SELECT p.id, p.nom AS personne_nom, 
                        t.document_etat, t.saisie_etat, t.declaration_etat, 
                        t.montant, t.paiement_etat, t.numero_recu, t.recu_etat,
                        t.login, t.mot_de_passe
                        FROM teleliquidation_personnes t
                        JOIN personnes p ON t.personne_id = p.id
                        WHERE t.mois = @mois AND t.annee = @annee 
                        AND p.type_tableau = 'teleliquidation'";
            var parameters = new MySqlParameter[] {
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
                string personnesQuery = @"SELECT id FROM personnes 
                                        WHERE type_tableau = 'teleliquidation' 
                                        AND (inactive_since IS NULL OR inactive_since > CURDATE())";
                DataTable personnes = DatabaseHelper.ExecuteQuery(personnesQuery);
                foreach (DataRow row in personnes.Rows)
                {
                    int personneId = Convert.ToInt32(row["id"]);
                    string insertQuery = @"INSERT INTO teleliquidation_personnes 
                                 (personne_id, document_etat, saisie_etat, declaration_etat, 
                                  paiement_etat, recu_etat, last_modified_by, mois, annee)
                                 VALUES 
                                 (@personne_id, 'non_arrive', 'non_fait', 'non_fait', 
                                  'non_fait', 'non_recu', @user_id, @mois, @annee)";
                    var insertParams = new MySqlParameter[] {
                        new MySqlParameter("@personne_id", personneId),
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
                LoadTeleLiquidationsForMonth(mois, annee);
            }
        }

        private void numAnnee_ValueChanged(object sender, EventArgs e)
        {
            if (cmbMois.SelectedIndex >= 0)
            {
                int mois = cmbMois.SelectedIndex + 1;
                int annee = (int)numAnnee.Value;
                LoadTeleLiquidationsForMonth(mois, annee);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (cmbMois.SelectedIndex >= 0)
            {
                int mois = cmbMois.SelectedIndex + 1;
                int annee = (int)numAnnee.Value;
                LoadTeleLiquidationsForMonth(mois, annee);
            }
            else
            {
                LoadTeleLiquidationsForCurrentMonth();
            }
        }

        private void ConfigureDataGridView()
        {
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            if (dataGridView.Columns.Contains("id")) dataGridView.Columns["id"].HeaderText = "ID";
            if (dataGridView.Columns.Contains("personne_nom")) dataGridView.Columns["personne_nom"].HeaderText = "Nom de la Personne";
            if (dataGridView.Columns.Contains("saisie_etat")) dataGridView.Columns["saisie_etat"].HeaderText = "État Saisie";
            if (dataGridView.Columns.Contains("declaration_etat")) dataGridView.Columns["declaration_etat"].HeaderText = "État Déclaration";
            if (dataGridView.Columns.Contains("montant")) dataGridView.Columns["montant"].HeaderText = "Montant";
            if (dataGridView.Columns.Contains("numero_recu")) dataGridView.Columns["numero_recu"].HeaderText = "Numéro Reçu";
            if (dataGridView.Columns.Contains("login")) dataGridView.Columns["login"].HeaderText = "Login";
            if (dataGridView.Columns.Contains("mot_de_passe")) dataGridView.Columns["mot_de_passe"].HeaderText = "Mot de Passe";

            if (dataGridView.Columns.Contains("document_etat")) dataGridView.Columns["document_etat"].Visible = false;
            if (dataGridView.Columns.Contains("paiement_etat")) dataGridView.Columns["paiement_etat"].Visible = false;
            if (dataGridView.Columns.Contains("recu_etat")) dataGridView.Columns["recu_etat"].Visible = false;

            dataGridView.CellFormatting += (sender, e) =>
            {
                if (e.RowIndex >= 0)
                {
                    var cell = dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    string columnName = dataGridView.Columns[e.ColumnIndex].Name;
                    Color back = Color.White; Color fore = Color.Black;

                    switch (columnName)
                    {
                        case "id":
                        case "personne_nom":
                            string documentEtat = dataGridView.Rows[e.RowIndex].Cells["document_etat"].Value?.ToString() ?? "";
                            back = documentEtat == "arrive" ? Color.LightGreen : documentEtat == "en_cours" ? Color.Orange : Color.LightCoral;
                            break;
                        case "saisie_etat":
                            string saisie = cell.Value?.ToString() ?? "";
                            back = saisie == "fait" ? Color.LightGreen : saisie == "en_cours" ? Color.Orange : Color.LightCoral;
                            break;
                        case "declaration_etat":
                            string decl = cell.Value?.ToString() ?? "";
                            back = decl == "fait" ? Color.LightGreen : decl == "en_cours" ? Color.Orange : Color.LightCoral;
                            break;
                        case "montant":
                            string pay = dataGridView.Rows[e.RowIndex].Cells["paiement_etat"].Value?.ToString() ?? "";
                            back = pay == "fait" ? Color.LightGreen : pay == "en_cours" ? Color.Orange : Color.LightCoral;
                            break;
                        case "numero_recu":
                            string recu = dataGridView.Rows[e.RowIndex].Cells["recu_etat"].Value?.ToString() ?? "";
                            back = recu == "recu" ? Color.LightGreen : recu == "en_attente" ? Color.Orange : Color.LightCoral;
                            break;
                    }

                    cell.Style.BackColor = back;
                    cell.Style.ForeColor = fore;
                }
            };
        }

        private void btnAddPersonne_Click(object sender, EventArgs e)
        {
            AddPersonneForm addPersonneForm = new AddPersonneForm();
            if (addPersonneForm.ShowDialog() == DialogResult.OK)
            {
                btnRefresh.PerformClick();
            }
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int personneId = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells["id"].Value);
                TeleliquidationPersonneDetailForm detailForm = new TeleliquidationPersonneDetailForm(personneId);
                detailForm.ShowDialog();
                if (cmbMois.SelectedIndex >= 0)
                {
                    int mois = cmbMois.SelectedIndex + 1;
                    int annee = (int)numAnnee.Value;
                    LoadTeleLiquidationsForMonth(mois, annee);
                }
                else
                {
                    LoadTeleLiquidationsForCurrentMonth();
                }
            }
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}