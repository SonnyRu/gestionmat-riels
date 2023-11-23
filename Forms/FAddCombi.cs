using GestionMatériels.DataAccess;
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
    public partial class FAddCombi : Form
    {
        public FAddCombi()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void boutonAddCombi_Click(object sender, EventArgs e)
        {
            string nom = "combinaison";
            string marque = boxMarque.Text;
            string taille = boxTaille.Text;
            string saison = boxSaison.Text;

            try
            {
                DBInterface.AjouterCombinaison(marque, nom, taille, saison);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite : " + ex.Message);
            }
            label5.Text = "Combinaison Ajoutée";
        }

        private void boutonretour_Click(object sender, EventArgs e)
        {
            FAccueil accueil = new FAccueil();
            accueil.Show();
            this.Hide();
        }

        private void FAddCombi_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
