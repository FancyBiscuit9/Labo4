using System;
using System.Collections.Generic;
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
        public int NAS { get; set; }
        public string NumeroCours { get; set; }
        public DateTime DateInscription { get; set; }
    }
}
