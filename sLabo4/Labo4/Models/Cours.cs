using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

/*
 * (0 point) La classe nommée "Cours" qui représente la table "Cours" ;
 */

namespace Labo4.Models
{
    public class Cours
    {
        [Display(Name = "Numero assurance social :")]
        [Required(ErrorMessage = "Le champ {0} est obligatoire")]
        public int NumeroCours { get; set; }

        [Display(Name = "Numero assurance social :")]
        [Required(ErrorMessage = "Le champ {0} est obligatoire")]
        [RegularExpression(@"[A-Z]\w{1,}}", ErrorMessage = "Veuillez entrer le l'intitule avec une majuscule en premier (et sans numero)")]
        public string Intitule { get; set; }

        [Display(Name = "Numero assurance social :")]
        [Required(ErrorMessage = "Le champ {0} est obligatoire")]
        public int NombreCredit { get; set; }

        [Display(Name = "Numero assurance social :")]
        [Required(ErrorMessage = "Le champ {0} est obligatoire")]
        [RegularExpression(@"[AHE]\d{4}", ErrorMessage = "Veuillez entrer le code de la session dans le format H2020")]
        public string Session { get; set; }
    }
}
