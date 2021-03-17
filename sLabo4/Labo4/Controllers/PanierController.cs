using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Labo4.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Labo4.Controllers
{
    public class PanierController : Controller
    {
        public readonly IConfiguration Configuration;
        public readonly CoursDataContext coursDataContext;
        public readonly EtudiantsDataContext etudiantsDataContext;
        public Panier panier;

        public PanierController(IConfiguration configuration)
        {
            this.Configuration = configuration;
            string strConnection = this.Configuration.GetConnectionString("Labo04Connection");
            this.etudiantsDataContext = new EtudiantsDataContext(strConnection);
            this.coursDataContext = new CoursDataContext(strConnection);
        }

        /*(0 point) La méthode nommée "Login". Cette méthode répond 
         à un clic sur le lien "Choix de Cours". Elle affiche une vue
         d'identification de l'étudiant.
         */

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        /* (0 point) La méthode nommée "Login". Cette méthode reçoit un objet de type 
        "LoginModel". Elle doit vérifier l'existence du numéro donné et le nom dans la table
        "Etudiants" et mettre à jour du panier. Cette méthode répond à un clic sur le bouton 
        "Submit" du formulaire de login. Elle nous redirige vers la méthode "ListeCours". 
        */

        /// <summary> 
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Login(LoginModel loginModel)
        {
            return View("ListeCours");
        }

        /* 
         * La méthode nommée "ListeCours". Cette méthode affiche la liste des cours de la table "Cours".
         */

         /// <summary>
         /// 
         /// </summary>
         /// <returns></returns>
        public IActionResult listeCours()
        {
            // va cerhcher toute les données de la base de données et les mets dans la liste
            List<Cours> listeCours = new List<Cours> (coursDataContext.Select());
            return View("listeCours", listeCours);
        }

        /* (0 point) La méthode nommée "AfficherPanier". Cette 
         * méthode répond à un clic sur le lien "Voir mon panier" 
         * et affiche le contenu du panier. 
         */

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IActionResult AfficherPanier()
        {
            return View();
        }

        /* (1 point) La méthode nommée "SupprimerCours". Cette méthode et 
         * appelée suite à un clic sur le lien "Supprimer" de la liste des cours 
         * du panier. Elle reçoit le numéro de cours comme paramètre et supprime 
         * le cours qui possède ce numéro du panier. Cette méthode nous redirige 
         * vers la méthode d'action "AfficherPanier
         */

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IActionResult SupprimerCours()
        {
            return View();
        }

        /* (2 points) La méthode nommée "ValidationPanier". Cette méthode répond 
         * à un clic sur le lien "Valider mes choix" et insert les cours choisis
         * (le contenu du panier) par l’étudiant dans la table "Inscriptions". Elle
         * nous redirige vers la méthode d'action "Accueil" du contrôleur "Home".
         */

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IActionResult ValidationPanier()
        {
            return View();
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}
 
 
 
 