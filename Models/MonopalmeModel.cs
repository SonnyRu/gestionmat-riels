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

        private string typemono;
        private string pointure;

        /// <summary>
        /// Type de la monopalme.
        /// </summary>
        public string TypeMono
        {
            get { return typemono; }
            set { typemono = value; }
        }

        /// <summary>
        /// Pointure de la monopalme.
        /// </summary>
        public string Pointure
        {
            get { return pointure; }
            set { pointure = value; }
        }

        /// <summary>
        /// Obtenir l'id de la monopalme.
        /// </summary>
        /// <returns>ID</returns>
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

        /// <summary>
        /// Constructeur de la classe MonopalmeMatérielClass.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="marque"></param>
        /// <param name="nom"></param>
        /// <param name="type"></param>
        /// <param name="pointure"></param>
        public MonopalmeModel(int id, string marque, string nom, string typemono, string pointure)
            : base(id, marque, nom)
        {
            TypeMono = typemono;
            Pointure = pointure;
        }

        public MonopalmeModel()
        {

        }
    }
}