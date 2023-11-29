using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionMatériels.Models
{
    /// <summary>
    /// Auteur : B. Chataing.
    /// Date de création : 8/12/2022.
    /// Date de modification :
    /// Modélise un compte épargne.
    /// </summary>
    class CombinaisonModel : MatérielModel
    {
        private string taille;
        private string saisonCombi;

        /// <summary>
        /// Taille de la Combinaison.
        /// </summary>
        public string Taille
        {
            get { return taille; }
            set { taille = value; }
        }

        /// <summary>
        /// Saison de la Combinaison.
        /// </summary>
        public string SaisonCombi
        {
            get { return saisonCombi; }
            set { saisonCombi = value; }
        }



        /// <summary>
        /// Obtenir l'id de la combinaison.
        /// </summary>
        /// <returns>ID</returns>
        public int GetId()
        {
            return Id;
        }

        /// <summary>
        /// Obtenir la marque de la combinaison
        /// </summary>
        /// <returns>Marque</returns>
        public string GetMarque()
        {
            return Marque;
        }

        /// <summary>
        /// Retourne le nom de la combinaison.
        /// </summary>
        /// <returns></returns>
        public string GetNom()
        {
            return Nom;
        }

        public string GetTaille()
        {
            return taille;
        }

        /// <summary>
        /// Constructeur de la classe CombinaisonMatérielClass.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="marque"></param>
        /// <param name="nom"></param>
        /// <param name="taille"></param>
        /// <param name="saisonCombi"></param>
        public CombinaisonModel(int id, string marque, string nom, string taille, string saisonCombi)
            : base(id, marque, nom)
        {
            Taille = taille;
            SaisonCombi = saisonCombi;
        }

        public CombinaisonModel()
        {

        }
    }
}
