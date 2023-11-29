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
            FVPrêts prêts = new FVPrêts();
            prêts.Show();
            this.Hide();
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FAccueil_Load(object sender, EventArgs e)
        {
            #region Voir Combinaison
            List<CombinaisonModel> materiels_combi = DBInterface.GetAllCombi("combinaison");
;
            // On teste que la liste ne soit pas vide. Si elle est vide, c'est qu'il y a eu une erreur...
            if (materiels_combi != null)
            {
                // On parcourt la liste de CombinaisonModel
                foreach (CombinaisonModel materiel_combi in materiels_combi)
                {
                    if (materiel_combi.Taille != "")
                    {
                        //On crée un tableau de chaines de caractères : une ligne contient les données d'un matériel
                        string[] row = { Convert.ToString(materiel_combi.Id), materiel_combi.Nom, materiel_combi.Marque, materiel_combi.SaisonCombi, materiel_combi.Taille, "", "" };
                        ListViewItem listViewItem = new ListViewItem(row);
                        //On ajoute la ligne dans la listeview
                        listcombi.Items.Add(listViewItem);
                    }
                }
            }
            #endregion

            #region Voir Monopalme
            List<MonopalmeModel> materiels_mono = DBInterface.GetAllMono("monopalme");
            if (materiels_mono != null)
            {
                //On parcourt la liste de MonopalmeModel
                foreach (MonopalmeModel materiel_mono in materiels_mono)
                {
                    if (materiel_mono.Pointure != "")
                    {
                        //On crée un tableau de chaines de caractères : une ligne contient les données d'un matériel
                        string[] row = { Convert.ToString(materiel_mono.Id), materiel_mono.Nom, materiel_mono.Marque, materiel_mono.TypeMono, materiel_mono.Pointure, "", "" };
                        ListViewItem listViewItem = new ListViewItem(row);
                        //On ajoute la ligne dans la listeview
                        listmono.Items.Add(listViewItem);
                    }
                }
            }
            #endregion

            #region Voir Tuba

            List<MatérielModel> tubas = DBInterface.GetAllTubas();
            if (tubas != null)
            {
                // On parcourt la liste de TubaModel
                foreach (MatérielModel tuba in tubas)
                {
                    // On crée un tableau de chaînes de caractères : une ligne contient les données d'un tuba
                    string[] row = { Convert.ToString(tuba.Id), tuba.Nom, tuba.Marque, "", "", "", "" };
                    ListViewItem listViewItem = new ListViewItem(row);
                    // On ajoute la ligne dans la listeview
                    listtuba.Items.Add(listViewItem);
                }
            }
            #endregion

            #region Voir Lunettes
            List<MatérielModel> lunettes = DBInterface.GetAllLunettes();

            if (lunettes != null)
            {
                // On parcourt la liste de LunettesModel
                foreach (MatérielModel lunette in lunettes)
                {
                    // On crée un tableau de chaînes de caractères : une ligne contient les données d'une lunette
                    string[] row = { Convert.ToString(lunette.Id), lunette.Nom, lunette.Marque, "", "", "", "" };
                    ListViewItem listViewItem = new ListViewItem(row);
                    // On ajoute la ligne dans la listeview
                    listlunette.Items.Add(listViewItem);
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

        private void listmono_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void actualisation_Click(object sender, EventArgs e)
        {
            #region Actualisation des ListView
            // Vide les ListView
            listcombi.Items.Clear();
            listmono.Items.Clear();
            listtuba.Items.Clear();
            listlunette.Items.Clear();

            // Récupération des nouvelles données de la base de données
            List<CombinaisonModel> materiels_combi = DBInterface.GetAllCombi("combinaison");
            List<MonopalmeModel> materiels_mono = DBInterface.GetAllMono("monopalme");
            List<MatérielModel> tubas = DBInterface.GetAllTubas();
            List<MatérielModel> lunettes = DBInterface.GetAllLunettes();

            // Mise à jour les ListView avec les nouvelles données
            if (materiels_combi != null)
            {
                foreach (CombinaisonModel materiel_combi in materiels_combi)
                {
                    if (materiel_combi.Taille != "")
                    {
                        string[] row = { materiel_combi.Nom, materiel_combi.Marque, materiel_combi.SaisonCombi, materiel_combi.Taille, "", "" };
                        ListViewItem listViewItem = new ListViewItem(row);
                        listcombi.Items.Add(listViewItem);
                    }
                }
            }

            if (materiels_mono != null)
            {
                foreach (MonopalmeModel materiel_mono in materiels_mono)
                {
                    if (materiel_mono.Pointure != "")
                    {
                        string[] row = { materiel_mono.Nom, materiel_mono.Marque, materiel_mono.TypeMono, materiel_mono.Pointure, "", "" };
                        ListViewItem listViewItem = new ListViewItem(row);
                        listmono.Items.Add(listViewItem);
                    }
                }
            }

            if (tubas != null)
            {
                foreach (MatérielModel tuba in tubas)
                {
                    string[] row = { tuba.Nom, tuba.Marque, "", "", "", "" };
                    ListViewItem listViewItem = new ListViewItem(row);
                    listtuba.Items.Add(listViewItem);
                }
            }

            if (lunettes != null)
            {
                foreach (MatérielModel lunette in lunettes)
                {
                    string[] row = { lunette.Nom, lunette.Marque, "", "", "", "" };
                    ListViewItem listViewItem = new ListViewItem(row);
                    listlunette.Items.Add(listViewItem);
                }
            }
            #endregion
        }

        private void monopalme_Click(object sender, EventArgs e)
        {
            FAddMono addmono = new FAddMono();
            addmono.Show();
            this.Hide();
        }
    }
}
