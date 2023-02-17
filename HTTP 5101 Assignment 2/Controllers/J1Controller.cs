using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HTTP_5101_Assignment_2.Controllers
{
    public class J1Controller : Controller
    {
        // GET: J1/Index
        public ActionResult Index()
        {
            return View();
        }

        // GET: J1/Menu?burger={burger}&drink={drink}&side={side}&dessert={dessert}
        // Acquire information about the meal and send it to Menu.cshtml
        public ActionResult Menu(int? burger, int? drink, int? side, int? dessert)
        {
            //gather the caolories from the meal provided
            J1APIController controller = new J1APIController();
            ViewBag.Calories = controller.GetCalories(burger, drink, side, dessert);

            return View();
        }
    }
}