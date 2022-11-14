using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FastVtc.Controllers
{
    public class MainController : Controller
    {
        [Route("~/"), Route("~/accueil")]
        public ActionResult GetHomePage()
        {
            return View("Home");
        }

        [Route("~/reservation")]
        public ActionResult GetBookingPage()
        {
            return View("Booking");
        }

        [Route("~/apropos")]
        public ActionResult GetAboutUsPage()
        {
            return View("AboutUs");
        }
    }
}
