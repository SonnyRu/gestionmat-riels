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

namespace GestionMatériels.Forms
{
    public partial class FVPrêts : Form
    {
        public FVPrêts()
        {
            InitializeComponent();
        }

        private void listPret_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FVPrêts_Load(object sender, EventArgs e)
        {
            #region Voir les Prêts
            List<PrêtModel> prêts = DBInterface.GetAllPrêt();

            //On teste que la liste ne soit pas vide. Si elle est vide, c'est qu'il y a eu une erreur...
            if (prêts != null)
            {
                //On parcourt la liste de CombinaisonMatérielClass
                foreach (PrêtModel prêt in prêts)
                {
                    //On crée un tableau de chaines de caractères : une ligne contient les données d'un matériel
                    string[] row = { prêt.Id.ToString(), prêt.Nageur.Nom1, prêt.Nageur.Prénom1, prêt.Matériel.Nom, prêt.Matériel.Marque, prêt.DateEmprunt.ToString(), prêt.DateRetour.ToString() };
                    ListViewItem listViewItem = new ListViewItem(row);
                    //On ajoute la ligne dans la listeview
                    listPret.Items.Add(listViewItem);
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
            listPret.Items.Clear();

            List<PrêtModel> prêts = DBInterface.GetAllPrêt();

            //On teste que la liste ne soit pas vide. Si elle est vide, c'est qu'il y a eu une erreur...
            if (prêts != null)
            {
                //On parcourt la liste de CombinaisonMatérielClass
                foreach (PrêtModel prêt in prêts)
                {
                    //On crée un tableau de chaines de caractères : une ligne contient les données d'un matériel
                    string[] row = { prêt.Id.ToString(), prêt.Nageur.Nom1, prêt.Nageur.Prénom1, prêt.Matériel.Nom, prêt.Matériel.Marque, prêt.DateEmprunt.ToString(), prêt.DateRetour.ToString() };
                    ListViewItem listViewItem = new ListViewItem(row);
                    //On ajoute la ligne dans la listeview
                    listPret.Items.Add(listViewItem);
                }
            }
            #endregion
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FAccueil accueil = new FAccueil();
            accueil.Show();
            this.Hide();
        }
    }
}
