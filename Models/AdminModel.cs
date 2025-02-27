﻿using System;
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
    /// Modélise un conseiller financier.
    /// </summary>
    public class AdminModel
    {
        #region Properties
        /// <summary>
        /// Id du conseiller.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nom du conseiller.
        /// </summary>
        public string Nom { get; set; }

        /// <summary>
        /// Prénom du conseiller.
        /// </summary>
        public string Prenom { get; set; }

        /// <summary>
        /// Login du conseiller.
        /// </summary>
        public string Login { get; set; }

        /// <summary>
        /// Hash du mot de passe du conseiller.
        /// </summary>
        public byte Password { get; set; }
        #endregion
    }
}
