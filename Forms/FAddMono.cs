using GestionMatériels.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionMatériels.Forms
{
    public partial class FAddMono : Form
    {
        public FAddMono()
        {
            InitializeComponent();
        }

        private void FAddMono_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FAccueil accueil = new FAccueil();
            accueil.Show();
            this.Hide();
        }

        private void boutonAddMono_Click(object sender, EventArgs e)
        {
            string nom = "monopalme";
            string marque = boxMarque.Text;
            string typemono = boxType.Text;
            string pointure = boxPointure.Text;

            try
            {
                DBInterface.AjouterMonopalme(marque, nom, typemono, pointure);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite : " + ex.Message);
            }
            label5.Text = "Monopalme Ajouté";
        }
    }
}
