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
    /// Modélise un compte.
    /// </summary>
    public abstract class MatérielModel
    {
        protected int id;
        private string marque;
        private string nom;

        /// <summary>
        /// Id du matériel.
        /// </summary>
        protected int Id { get => id; set => id = value; }

        /// <summary>
        /// Marque du matériel.
        /// </summary>
        protected string Marque { get => marque; set => marque = value; }

        /// <summary>
        /// Nom du matériel
        /// </summary>
        protected string Nom { get => nom; set => nom = value; }

        public MatérielModel(int id, string marque, string nom)
        {
            Id = id;
            Marque = marque;
            Nom = nom;
        }

        public string GetNom()
        {
            return Nom;
        }
    }
}
