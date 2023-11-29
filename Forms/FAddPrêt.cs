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
    public partial class FAddPrêt : Form
    {
        public FAddPrêt()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FAddPrêt_Load(object sender, EventArgs e)
        {

        }

        private void boutonAddCombi_Click(object sender, EventArgs e)
        {
            string dateEmprunt = dateemprunt.Text;
            string dateRetour = dateretour.Text;
            string IdNageur = idnageur.Text;
            string IdMateriel = idmateriel.Text;

            try
            {
                DBInterface.AjouterCombinaison(dateEmprunt, dateRetour, IdNageur, IdMateriel);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite : " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FAccueil accueil = new FAccueil();
            accueil.Show();
            this.Hide();
        }
    }
}
