using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/*
 * (0 point) La classe nommée "Cours" qui représente la table "Cours" ;
 */

namespace Labo4.Models
{
    public class Cours
    {
        public int NumeroCours { get; set; }
        public string Intitule { get; set; }
        public int NombreCredit { get; set; }
        public string Session { get; set; }
    }
}
