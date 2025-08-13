using System;
using System.Drawing;
using System.Windows.Forms;

namespace Comptabilite
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
            lblWelcome.Text = $"Bienvenue, {LoginForm.CurrentUserFullName}";
        }

        private void btnPersonnesPhysiques_Click(object sender, EventArgs e)
        {
            PersonnesPhysiquesMenuForm personnesPhysiquesForm = new PersonnesPhysiquesMenuForm();
            this.Hide();
            personnesPhysiquesForm.ShowDialog();
            this.Show();
        }

        private void btnPersonnesMorales_Click(object sender, EventArgs e)
        {
            PersonnesMoralesMenuForm personnesMoralesForm = new PersonnesMoralesMenuForm();
            this.Hide();
            personnesMoralesForm.ShowDialog();
            this.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
} 