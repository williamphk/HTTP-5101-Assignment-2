using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HTTP_5101_Assignment_2.Controllers
{
    public class J2Controller : Controller
    {
        // GET: J2/Index
        public ActionResult Index()
        {
            return View();
        }

        // GET: J2/DiceGame?m={m}&n={n}
        // Acquire information about the dice and send it to DiceGame.cshtml
        public ActionResult DiceGame(int? m, int? n)
        {
            {
                //gather the number of ways to roll 10 from the dice provided
                J2APIController controller = new J2APIController();
                ViewBag.Ways = controller.GetWaysToRollTen(m, n);
            }

            return View();
        }
    }
}