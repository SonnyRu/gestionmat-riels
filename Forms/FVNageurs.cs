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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GestionMatériels.Forms
{
    public partial class FVNageurs : Form
    {
        public FVNageurs()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FAccueil accueil = new FAccueil();
            accueil.Show();
            this.Hide();
        }

        private void FVNageurs_Load(object sender, EventArgs e)
        {

            #region Voir les Nageurs
            List<NageurModel> nageurs = DBInterface.GetAllNageurs();

            //On teste que la liste ne soit pas vide. Si elle est vide, c'est qu'il y a eu une erreur...
            if (nageurs != null)
            {
                //On parcourt la liste de CombinaisonMatérielClass
                foreach (NageurModel nageur in nageurs)
                {
                    //On crée un tableau de chaines de caractères : une ligne contient les données d'un matériel
                    string[] row = { Convert.ToString(nageur.Id1), nageur.Nom1, nageur.Prénom1, nageur.Mail1, nageur.Téléphone1 };
                    ListViewItem listViewItem = new ListViewItem(row);
                    //On ajoute la ligne dans la listeview
                    voirnageurs.Items.Add(listViewItem);
                }
            }
            #endregion

            #region Bouton Actualisation
            actualisation.Click += async (sender, e) =>
            {
                Image originalImage = (Image)actualisation.Image.Clone();

                for (int i = 0; i < 15; i++)
                {
                    originalImage.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    actualisation.Image = originalImage;
                    actualisation.Refresh();
                    await Task.Delay(150);
                }
            };
            #endregion
        }

        private void actualisation_Click(object sender, EventArgs e)
        {
            #region Actualisation des ListView
            // Vide les ListView
            voirnageurs.Items.Clear();

            // Récupération des nouvelles données de la base de données
            List<NageurModel> nageurs = DBInterface.GetAllNageurs();

            // Mise à jour les ListView avec les nouvelles données
            if (nageurs != null)
            {
                foreach (NageurModel nageur in nageurs)
                {
                    string[] row = { Convert.ToString(nageur.Id1), nageur.Nom1, nageur.Prénom1, nageur.Mail1, nageur.Téléphone1 };
                    ListViewItem listViewItem = new ListViewItem(row);
                    voirnageurs.Items.Add(listViewItem);
                }
            }
            #endregion
        }
    }
}
