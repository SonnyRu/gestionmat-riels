using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionMatériels.Models
{
    public class PrêtModel
    {
        private int id;
        private DateTime dateEmprunt;
        private DateTime dateRetour;
        private NageurModel nageur;
        private MatérielModel matériel;

        public int Id { get; set; }

        public DateTime DateRetour { get; set; }

        public DateTime DateRetourSansHeure
        {
            get { return DateRetour.Date; }
        }

        public DateTime DateEmprunt { get; set; }

        public DateTime DateEmpruntSansHeure
        {
            get { return DateEmprunt.Date; }
        }

        public NageurModel Nageur { get; set; }

        public MatérielModel Matériel { get; set; }

        public PrêtModel(int id, DateTime dateEmprunt, DateTime dateRetour, NageurModel nageur, MatérielModel matériel)
        {
            Id = id;
            DateEmprunt = dateEmprunt;
            DateRetour = dateRetour;
            Nageur = nageur;
            Matériel = matériel;
        }

        public PrêtModel() { }
    }
}
