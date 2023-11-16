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
    /// Modélise un client.
    /// </summary>
    public class NageurModel
    {
        private int Id;
        private string Nom;
        private string Prénom;
        private string Mail;
        private string Téléphone;

        public int Id1 { get => Id; set => Id = value; }
        public string Nom1 { get => Nom; set => Nom = value; }
        public string Prénom1 { get => Prénom; set => Prénom = value; }
        public string Mail1 { get => Mail; set => Mail = value; }
        public string Téléphone1 { get => Téléphone; set => Téléphone = value; }

        public NageurModel(int id, string nom, string prénom, string mail, string téléphone)
        {
            Id1 = id;
            Nom1 = nom;
            Prénom1 = prénom;
            Mail1 = mail;
            Téléphone1 = téléphone;
        }

    }
}
