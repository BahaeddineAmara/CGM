using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Comptabilite
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            lblWelcome.Text = $"Bienvenue, {LoginForm.CurrentUserFullName}";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitializeDateControls();
            LoadTeleDeclarationsForCurrentMonth();
            ConfigureDataGridView();
        }

        private void InitializeDateControls()
        {
            // Initialiser le ComboBox des mois (vous devez l'ajouter au designer)
            cmbMois.Items.AddRange(new string[] {
        "Janvier", "Février", "Mars", "Avril", "Mai", "Juin",
        "Juillet", "Août", "Septembre", "Octobre", "Novembre", "Décembre"
    });

            // Initialiser le NumericUpDown pour l'année (vous devez l'ajouter au designer)
            numAnnee.Minimum = 2020;
            numAnnee.Maximum = 2050;
            numAnnee.Value = DateTime.Now.Year;

            // Sélectionner le mois actuel
            cmbMois.SelectedIndex = DateTime.Now.Month - 1;
        }

        private void LoadTeleDeclarationsForCurrentMonth()
        {
            int moisActuel = DateTime.Now.Month;
            int anneeActuelle = DateTime.Now.Year;
            LoadTeleDeclarationsForMonth(moisActuel, anneeActuelle);
        }

        private void LoadTeleDeclarationsForMonth(int mois, int annee)
        {
            // Vérifier si les données existent pour ce mois/année
            string checkQuery = @"SELECT COUNT(*) FROM teledeclaration td
                         JOIN societes s ON td.societe_id = s.id
                         WHERE td.mois = @mois AND td.annee = @annee 
                         AND s.type_tableau = 'teledeclaration'";

            MySqlParameter[] checkParams = {
        new MySqlParameter("@mois", mois),
        new MySqlParameter("@annee", annee)
    };

            int count = Convert.ToInt32(DatabaseHelper.ExecuteScalar(checkQuery, checkParams));

            if (count == 0)
            {
                // Créer les données pour ce mois avec seulement les sociétés de type teledeclaration
                CreateMonthlyData(mois, annee);
            }

            // Charger les données - seulement les sociétés de type teledeclaration
            string query = @"SELECT s.id, s.nom AS societe_nom, 
                    td.document_etat, td.saisie_etat, td.declaration_etat, 
                    td.montant, td.paiement_etat, td.quittance_numero, td.quittance_etat,
                    td.login, td.mot_de_passe
                    FROM teledeclaration td
                    JOIN societes s ON td.societe_id = s.id
                    WHERE td.mois = @mois AND td.annee = @annee 
                    AND s.type_tableau = 'teledeclaration'";

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
                // Récupérer seulement les sociétés actives de type teledeclaration
                string societesQuery = @"SELECT id FROM societes 
                                        WHERE type_tableau = 'teledeclaration' 
                                        AND (inactive_since IS NULL OR inactive_since > CURDATE())";
                DataTable societes = DatabaseHelper.ExecuteQuery(societesQuery);

                foreach (DataRow row in societes.Rows)
                {
                    int societeId = Convert.ToInt32(row["id"]);

                    // Créer une entrée par défaut pour chaque société
                    string insertQuery = @"INSERT INTO teledeclaration 
                                 (societe_id, document_etat, saisie_etat, declaration_etat, 
                                  paiement_etat, quittance_etat, last_modified_by, mois, annee)
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
                LoadTeleDeclarationsForMonth(mois, annee);
            }
        }

        private void numAnnee_ValueChanged(object sender, EventArgs e)
        {
            if (cmbMois.SelectedIndex >= 0)
            {
                int mois = cmbMois.SelectedIndex + 1;
                int annee = (int)numAnnee.Value;
                LoadTeleDeclarationsForMonth(mois, annee);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (cmbMois.SelectedIndex >= 0)
            {
                int mois = cmbMois.SelectedIndex + 1;
                int annee = (int)numAnnee.Value;
                LoadTeleDeclarationsForMonth(mois, annee);
            }
            else
            {
                LoadTeleDeclarationsForCurrentMonth();
            }
        }

        private void ConfigureDataGridView()
        {
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Configurer les en-têtes des colonnes pour plus de clarté
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
            if (dataGridView.Columns.Contains("banque"))
                dataGridView.Columns["banque"].HeaderText = "Banque";
            if (dataGridView.Columns.Contains("quittance_numero"))
                dataGridView.Columns["quittance_numero"].HeaderText = "Numéro Quittance";
            if (dataGridView.Columns.Contains("login"))
                dataGridView.Columns["login"].HeaderText = "Login";
            if (dataGridView.Columns.Contains("mot_de_passe"))
                dataGridView.Columns["mot_de_passe"].HeaderText = "Mot de Passe";

            // Masquer les colonnes d'état
            if (dataGridView.Columns.Contains("document_etat"))
                dataGridView.Columns["document_etat"].Visible = false;
            if (dataGridView.Columns.Contains("paiement_etat"))
                dataGridView.Columns["paiement_etat"].Visible = false;
            if (dataGridView.Columns.Contains("quittance_etat"))
                dataGridView.Columns["quittance_etat"].Visible = false;

            // Set up cell formatting for colors
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
                            // Coloration basée sur document_etat
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
                        case "banque":
                            // Coloration basée sur paiement_etat
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

                        case "quittance_numero":
                            // Coloration basée sur quittance_etat
                            string quittanceEtat = dataGridView.Rows[e.RowIndex].Cells["quittance_etat"].Value?.ToString() ?? "";
                            switch (quittanceEtat)
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



        private void btnAddSociete_Click(object sender, EventArgs e)
        {
            AddSocieteForm addSocieteForm = new AddSocieteForm();
            if (addSocieteForm.ShowDialog() == DialogResult.OK)
            {
                // Remplacez LoadTeleDeclarations() par :
                if (cmbMois.SelectedIndex >= 0)
                {
                    int mois = cmbMois.SelectedIndex + 1;
                    int annee = (int)numAnnee.Value;
                    LoadTeleDeclarationsForMonth(mois, annee);
                }
                else
                {
                    LoadTeleDeclarationsForCurrentMonth();
                }
            }
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int societeId = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells["id"].Value);
                // Ici, ouvrir le SocieteDetailForm en passant l'id de la société (adapter le constructeur si besoin)
                SocieteDetailForm detailForm = new SocieteDetailForm(societeId);
                detailForm.ShowDialog();

                // Recharger les données pour refléter immédiatement les changements et la coloration
                if (cmbMois.SelectedIndex >= 0)
                {
                    int mois = cmbMois.SelectedIndex + 1;
                    int annee = (int)numAnnee.Value;
                    LoadTeleDeclarationsForMonth(mois, annee);
                }
                else
                {
                    LoadTeleDeclarationsForCurrentMonth();
                }
            }
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}