using GestionMatériels.DataAccess;
using GestionMatériels.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace GestionMatériels.Forms
{
    public partial class Connexion : Form
    {
        private AdminModel admin;
        public Connexion()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void boutonConnexion_Click(object sender, EventArgs e)
        {
            string login, password;
            login = usernameBox.Text;
            password = passwordBox.Text;
            try
            {
                using (SHA512Managed sha2 = new SHA512Managed())
                {
                    var password_hash = sha2.ComputeHash(Encoding.UTF8.GetBytes(password));
                    admin = DBInterface.GetAdmin(login, password_hash);
                }
                //On teste que le conseiller ne soit pas vide. Si il est vide, c'est qu'il y a eu une erreur...
                if (admin != null)
                {
                    if (admin.Prenom == null || admin.Nom == null)
                    {
                        authentif.Text = "Identifiants de connexion invalides";
                    }
                    else
                    {
                        authentif.Text = "Vous êtes connecté.";
                        FAccueil accueil = new FAccueil();
                        accueil.Show();
                        this.Hide();
                    }
                }
            }
            catch (Exception ex)
            {
                // Affiche un MessageBox si une exception est levée
                MessageBox.Show("Erreur de connexion à la base de données: " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void authentif_Click(object sender, EventArgs e)
        {

        }
    }
}
