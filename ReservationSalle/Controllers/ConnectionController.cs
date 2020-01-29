using ReservationSalle.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ReservationSalle.Controllers
{
    public class ConnectionController : Controller
    {
        // GET: Connection
        static Model1 model = new Model1();
        public ActionResult Connect()
        {
            var Authentifie = HttpContext.User.Identity.IsAuthenticated;
            ViewData["Authentifie"] = Authentifie;
            return View("Connect");
        }          
        [HttpPost]
        public ActionResult Connect(User userL)
        {
            var Authentifie = HttpContext.User.Identity.IsAuthenticated;
            ViewData["Authentifie"] = Authentifie;
            User user = null;
            if (Authentifie)
            {
                using (var db = new Model1())
                {
                    user = (from p in db.Users
                                where p.Login == HttpContext.User.Identity.Name
                                select p).FirstOrDefault();
                }
            }

            return View("Connect", user);
        }  
        
        public ActionResult Inscrire()
        {

            return View("Inscrire");
        }
        
        [HttpPost]
        public ActionResult Inscrire(User user)
        {
            if (ModelState.IsValid)
            {


                model.Users.Add(user);
                model.SaveChanges();

                //FormsAuthentication.SetAuthCookie(personne.Login.ToString(), true);

            }
            return View("Inscrire", user);
        }
    }
}