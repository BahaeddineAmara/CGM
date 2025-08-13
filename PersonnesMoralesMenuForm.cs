using System;
using System.Drawing;
using System.Windows.Forms;

namespace Comptabilite
{
    public partial class PersonnesMoralesMenuForm : Form
    {
        public PersonnesMoralesMenuForm()
        {
            InitializeComponent();
        }

        private void btnListeSocietes_Click(object sender, EventArgs e)
        {
            ListeSocietesForm listeSocietesForm = new ListeSocietesForm();
            this.Hide();
            listeSocietesForm.ShowDialog();
            this.Show();
        }

        private void btnTableTeledeclarations_Click(object sender, EventArgs e)
        {
            MainForm teledeclarationsForm = new MainForm();
            this.Hide();
            teledeclarationsForm.ShowDialog();
            this.Show();
        }

        private void btnTableTeleliquidation_Click(object sender, EventArgs e)
        {
            TeleliquidationForm teleliquidationForm = new TeleliquidationForm();
            this.Hide();
            teleliquidationForm.ShowDialog();
            this.Show();
        }

        private void btnTableReferencesFinancieres_Click(object sender, EventArgs e)
        {
            RecetteFinanceForm recetteFinanceForm = new RecetteFinanceForm();
            this.Hide();
            recetteFinanceForm.ShowDialog();
            this.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
} 