using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Comptabilite
{
    public partial class ListePersonnesForm : Form
    {
        public ListePersonnesForm()
        {
            InitializeComponent();
        }

        private void ListePersonnesForm_Load(object sender, EventArgs e)
        {
            LoadPersonnes();
            ConfigureDataGridView();
        }

        private void LoadPersonnes()
        {
            try
            {
                string query = @"SELECT id, nom, adresse, numero_telephone, email, code_tva, nature_contrat, 
                                CASE 
                                    WHEN type_tableau = 'teledeclaration' THEN 'Télédéclaration'
                                    WHEN type_tableau = 'teleliquidation' THEN 'Téléliquidation'
                                    WHEN type_tableau = 'recette_finance' THEN 'Recette Finance'
                                    ELSE 'Non défini'
                                END AS type_tableau_display,
                                CASE 
                                    WHEN inactive_since IS NULL OR inactive_since > CURDATE() THEN 'Active'
                                    ELSE 'Inactive'
                                END AS statut_activite,
                                active_since,
                                inactive_since
                                FROM personnes ORDER BY nom";
                DataTable dt = DatabaseHelper.ExecuteQuery(query);
                dataGridView.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des personnes: {ex.Message}", 
                               "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigureDataGridView()
        {
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.ReadOnly = true;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.RowHeadersVisible = false;

            // Configure column headers
            if (dataGridView.Columns.Contains("id"))
                dataGridView.Columns["id"].HeaderText = "ID";
            if (dataGridView.Columns.Contains("nom"))
                dataGridView.Columns["nom"].HeaderText = "Nom";
            if (dataGridView.Columns.Contains("adresse"))
                dataGridView.Columns["adresse"].HeaderText = "Adresse";
            if (dataGridView.Columns.Contains("numero_telephone"))
                dataGridView.Columns["numero_telephone"].HeaderText = "Téléphone";
            if (dataGridView.Columns.Contains("email"))
                dataGridView.Columns["email"].HeaderText = "Email";
            if (dataGridView.Columns.Contains("code_tva"))
                dataGridView.Columns["code_tva"].HeaderText = "Code TVA";
            if (dataGridView.Columns.Contains("nature_contrat"))
                dataGridView.Columns["nature_contrat"].HeaderText = "Nature Contrat";
            if (dataGridView.Columns.Contains("type_tableau_display"))
                dataGridView.Columns["type_tableau_display"].HeaderText = "Type Tableau";
            if (dataGridView.Columns.Contains("statut_activite"))
                dataGridView.Columns["statut_activite"].HeaderText = "Statut";
            
            // Masquer les colonnes techniques
            if (dataGridView.Columns.Contains("active_since"))
                dataGridView.Columns["active_since"].Visible = false;
            if (dataGridView.Columns.Contains("inactive_since"))
                dataGridView.Columns["inactive_since"].Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddPersonneForm addPersonneForm = new AddPersonneForm();
            if (addPersonneForm.ShowDialog() == DialogResult.OK)
            {
                LoadPersonnes();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells["id"].Value);
                EditPersonneForm editPersonneForm = new EditPersonneForm(id);
                if (editPersonneForm.ShowDialog() == DialogResult.OK)
                {
                    LoadPersonnes();
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une personne à modifier.", 
                               "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnArreterActivite_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells["id"].Value);
                string nom = dataGridView.SelectedRows[0].Cells["nom"].Value.ToString();
                string statut = dataGridView.SelectedRows[0].Cells["statut_activite"].Value.ToString();

                if (statut == "Inactive")
                {
                    MessageBox.Show($"La personne '{nom}' est déjà inactive.", 
                                   "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                DialogResult result = MessageBox.Show($"Êtes-vous sûr de vouloir arrêter l'activité de la personne '{nom}' ?\n\nCette personne ne sera plus présente dans les tableaux futurs, mais son historique sera conservé.", 
                                                    "Confirmation d'arrêt d'activité", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    ArreterActivitePersonne(id);
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une personne à désactiver.", 
                               "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnActiver_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells["id"].Value);
                string nom = dataGridView.SelectedRows[0].Cells["nom"].Value.ToString();
                string statut = dataGridView.SelectedRows[0].Cells["statut_activite"].Value.ToString();

                if (statut == "Active")
                {
                    MessageBox.Show($"La personne '{nom}' est déjà active.", 
                                   "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                DialogResult result = MessageBox.Show($"Êtes-vous sûr de vouloir activer la personne '{nom}' ?\n\nCette personne sera présente dans les tableaux à partir du mois en cours.", 
                                                    "Confirmation d'activation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    ActiverPersonne(id);
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une personne à activer.", 
                               "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ArreterActivitePersonne(int id)
        {
            try
            {
                // Marquer la personne comme inactive à partir du mois en cours
                string updateQuery = "UPDATE personnes SET inactive_since = CURDATE() WHERE id = @id";
                MySqlParameter[] updateParams = { new MySqlParameter("@id", id) };
                DatabaseHelper.ExecuteNonQuery(updateQuery, updateParams);

                MessageBox.Show("Activité de la personne arrêtée avec succès.\n\nCette personne ne sera plus présente dans les tableaux futurs, mais son historique sera conservé.", 
                               "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadPersonnes();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'arrêt d'activité: {ex.Message}", 
                               "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActiverPersonne(int id)
        {
            try
            {
                // Réactiver la personne en supprimant la date d'inactivation
                string updateQuery = "UPDATE personnes SET inactive_since = NULL WHERE id = @id";
                MySqlParameter[] updateParams = { new MySqlParameter("@id", id) };
                DatabaseHelper.ExecuteNonQuery(updateQuery, updateParams);

                MessageBox.Show("Personne activée avec succès.\n\nCette personne sera présente dans les tableaux à partir du mois en cours.", 
                               "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadPersonnes();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'activation: {ex.Message}", 
                               "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadPersonnes();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btnEdit_Click(sender, e);
            }
        }
    }
} 