using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Labo4.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Labo4.Controllers
{
    public class EtudiantsController : Controller
    {
        public readonly IConfiguration Configuration;
        public readonly EtudiantsDataContext EtudiantDataContext;

        public EtudiantsController(IConfiguration configuration)
        {
            this.Configuration = configuration;
            string strConnection = this.Configuration.GetConnectionString("Labo04Connection");
            this.EtudiantDataContext = new EtudiantsDataContext(strConnection);
        }

        /*
         * (0 point) La méthode nommée "Ajouter". Cette méthode ne reçoit aucun 
         * paramètre et répond à un clic sur le lien "Nouveau étudiant". Elle 
         * affiche un formulaire pour saisir les informations sur l'étudiant.
         */

        public IActionResult Action()
        {
            return View();
        }

        /*
         * (0 point) La méthode nommée "Ajouter". Cette méthode reçoit un
         * objet de type "Etudiant" et l'insert dans la table "Etudiants".
         * Cette méthode répond à un clic sur le bouton "Submit" du formulaire.
         */

        public IActionResult Action(Etudiants etudiant)
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}