using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Comptabilite
{
    public partial class LoginForm : Form
    {
        public static int CurrentUserId { get; private set; }
        public static string CurrentUserFullName { get; private set; }

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string nom = txtNom.Text.Trim();
            string prenom = txtPrenom.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(nom) || string.IsNullOrEmpty(prenom) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Veuillez remplir tous les champs", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = "SELECT id, nom, prenom FROM users WHERE nom = @nom AND prenom = @prenom AND password = @password";
            MySqlParameter[] parameters = {
                new MySqlParameter("@nom", nom),
                new MySqlParameter("@prenom", prenom),
                new MySqlParameter("@password", password)
            };

            DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);

            if (dt.Rows.Count > 0)
            {
                CurrentUserId = Convert.ToInt32(dt.Rows[0]["id"]);
                CurrentUserFullName = $"{dt.Rows[0]["prenom"]} {dt.Rows[0]["nom"]}";

                this.Hide();
                MainMenuForm mainMenuForm = new MainMenuForm();
                mainMenuForm.Show();
            }
            else
            {
                MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}