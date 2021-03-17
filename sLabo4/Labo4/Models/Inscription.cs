using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

/*
 * 4)	(0 point) La classe nommée "Inscription". 
 * Cette classe représente la table "Inscriptions" 
 */

namespace Labo4.Models
{
    public class Inscription
    {
        [Display(Name = "Numero assurance social :")]
        [Required(ErrorMessage = "Le champ {0} est obligatoire")]
        [RegularExpression(@"\d{3} \d{3} \d{3}", ErrorMessage = "Veuillez entrer le NAS dans le format 999 999 999")]
        public int NAS { get; set; }

        [Display(Name = "Numero assurance social :")]
        [Required(ErrorMessage = "Le champ {0} est obligatoire")]
        [Range(1, 999999, ErrorMessage = "Veuillez entrer un nombre entre 1 et 999999")]
        public string NumeroCours { get; set; }

        [Display(Name = "Numero assurance social :")]
        [Required(ErrorMessage = "Le champ {0} est obligatoire")]
        public DateTime DateInscription { get; set; }
    }
}
