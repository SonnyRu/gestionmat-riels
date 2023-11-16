using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionMatériels.Forms
{
    public partial class Connexion : Form
    {
        public Connexion()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void boutonConnexion_Click(object sender, EventArgs e)
        {
            if (usernameBox.Text == "GestMat" && passwordBox.Text == "C1Secret!")
            {

                FAccueil accueil = new FAccueil();
                accueil.Show();
                this.Hide();
            }
            else if (usernameBox.Text == "GestMat")
            {
                authentifmdp.Text = "Incorrect";
                authentif.Text = " ";
            }
            else if (passwordBox.Text == "C1Secret!")
            {
                authentif.Text = "Incorrect";
                authentifmdp.Text = " ";
            }
            else
            {
                authentif.Text = "Incorrect";
                authentifmdp.Text = "Incorrect";
            }
        }

        private void authentif_Click(object sender, EventArgs e)
        {

        }
    }
}
