using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace finproj.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Form()
        {
            return View();
        }

        public ActionResult Absolute()
        {
            return View();
        }

        public ActionResult Static()
        {
            return View();
        }

        public ActionResult Float()
        {
            return View();
        }

        public ActionResult Client()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult ServerSide()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ServerSide(string inputNumber)
        {
            if (string.IsNullOrEmpty(inputNumber) || (inputNumber.Length != 10))
            {
                //shouldn't be possible anymore
                return Content("invalid input, please try again");
            }
            else
            {
                string formatted = formatNumber(inputNumber);
                return View("ServerResult", (object)formatted);
            }
        }

        private string formatNumber(string inputNumber)
        {
            return String.Format("formated number is: ({0}) {1}-{2}", inputNumber.Substring(0, 3), inputNumber.Substring(3, 3), inputNumber.Substring(6, 4));
        }
    }
}
