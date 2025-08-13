using System;
using System.Drawing;
using System.Windows.Forms;

namespace Comptabilite
{
    public partial class PersonnesPhysiquesMenuForm : Form
    {
        public PersonnesPhysiquesMenuForm()
        {
            InitializeComponent();
        }

        private void btnListePersonnes_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListePersonnesForm listePersonnesForm = new ListePersonnesForm();
            listePersonnesForm.ShowDialog();
            this.Show();
        }

        private void btnTableTeledeclaration_Click(object sender, EventArgs e)
        {
            this.Hide();
            TeledeclarationPersonnesForm teledeclarationPersonnesForm = new TeledeclarationPersonnesForm();
            teledeclarationPersonnesForm.ShowDialog();
            this.Show();
        }

        private void btnTableTeleliquidation_Click(object sender, EventArgs e)
        {
            this.Hide();
            TeleliquidationPersonnesForm form = new TeleliquidationPersonnesForm();
            form.ShowDialog();
            this.Show();
        }

        private void btnTableReferencesFinancieres_Click(object sender, EventArgs e)
        {
            RecetteFinancePersonnesForm recetteFinancePersonnesForm = new RecetteFinancePersonnesForm();
            this.Hide();
            recetteFinancePersonnesForm.ShowDialog();
            this.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
} 