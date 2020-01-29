using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ReservationSalle.Controllers
{
    public class AdminController : Controller
    {
      
        public ActionResult Accueil()
        {
            return View();
        }
    }
}