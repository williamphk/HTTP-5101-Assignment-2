using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HTTP_5101_Assignment_2.Controllers
{
    public class J3Controller : Controller
    {
        // GET: J3/Index
        public ActionResult Index()
        {
            return View();
        }

        // GET: J3/hiddenPalindrome?word={word}
        // Acquire the total number of letters of the longest palindrome of the word and send it to hiddenPalindrome.cshtml
        public ActionResult hiddenPalindrome(string word)
        {
            J3APIController controller = new J3APIController();
            ViewBag.Palindrome = controller.GetMaxPalidrome(word);
            return View();
        }
    }
}