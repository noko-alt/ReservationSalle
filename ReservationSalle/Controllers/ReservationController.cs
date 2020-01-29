using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ReservationSalle.Controllers
{
    public class ReservationController : Controller
    {
        
        public ActionResult Reserver()
        {
            return View();
        }

        public ActionResult Reservee()
        {
            return View();
        }
    }
}