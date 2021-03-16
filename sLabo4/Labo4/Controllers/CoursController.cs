using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Labo4.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Labo4.Controllers
{
    public class CoursController : Controller
    {
        public readonly IConfiguration Configuration;
        public readonly CoursDataContext coursDataContext;

        public CoursController(IConfiguration configuration)
        {
            this.Configuration = configuration;
            string strConnection = this.Configuration.GetConnectionString("Labo04");
            this.coursDataContext = new CoursDataContext(strConnection);
        }

        /*
         * (0 point) La méthode nommée "Ajouter". Cette méthode ne reçoit aucun 
         * paramètre et répond à un clic sur le lien "Nouveau Cours". Elle affiche 
         * un formulaire pour saisir les informations sur le cours.
         */

        public IActionResult Action()
        {
            return View();
        }

        /*
         * (0 point) La méthode nommée "Ajouter". Cette méthode reçoit 
         * un objet de type "Cours" et l'insert dans la table "Cours". Cette méthode répond à 
         * un clic sur le bouton "Submit" du formulaire de saisie. Elle nous redirige vers 
         * la méthode "Accueil" du contrôleur "Home"
         */

        public IActionResult Action(Cours cours)
        {
            return View();
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}
 
 