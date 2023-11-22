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
    public partial class FAccueil : Form
    {
        public FAccueil()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void liststock_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listcombi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void combi_Click(object sender, EventArgs e)
        {
            FAddCombi addombi = new FAddCombi();
            addombi.Show();
            this.Hide();
        }

        private void btnPret_Click(object sender, EventArgs e)
        {

        }

        private void deconnexion_Click(object sender, EventArgs e)
        {
            Connexion connexion = new Connexion();
            connexion.Show();
            this.Hide();
        }

        private void nageurs_Click(object sender, EventArgs e)
        {
            FVNageurs nageur = new FVNageurs();
            nageur.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
