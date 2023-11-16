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
    /// Date de modification : 27/12/2022.
    /// Modélise un compte courant.
    /// </summary>
    public class MonopalmeModel : MatérielModel
    {

        private string type;
        private string pointure;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public string Pointure
        {
            get { return pointure; }
            set { pointure = value; }
        }

        #region Constructeur
        /// <summary>
        /// Constructeur de la classe MonopalmeMatérielClass.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="marque"></param>
        /// <param name="nom"></param>
        /// <param name="type"></param>
        /// <param name="pointure"></param>
        public MonopalmeModel(int id, string marque, string nom, string type, string pointure)
            : base(id, marque, nom)
        {
            Type = type;
            Pointure = pointure;
        }
        #endregion

        #region méthodes
        /// <summary>
        /// Retourne l'id du Matériel.
        /// </summary>
        /// <returns></returns>
        public int GetId()
        {
            return Id;
        }

        /// <summary>
        /// Obtenir la marque de la monopalme
        /// </summary>
        /// <returns>Marque</returns>
        public string GetMarque()
        {
            return Marque;
        }

        /// <summary>
        /// Retourne le nom de la monopalme.
        /// </summary>
        /// <returns></returns>
        public string GetNom()
        {
            return Nom;
        }
        #endregion
    }
}