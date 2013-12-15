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
        [HttpPost]
        public ActionResult Form(finproj.Models.FormModel form) {
            List<string> formInfo = new List<string>();
            formInfo.Add(String.Format("Name: {0}", form.name));
            formInfo.Add(String.Format("Email: {0}", form.email));
            formInfo.Add(String.Format("Phone Number: {0}", form.phone));
            formInfo.Add(String.Format("Arrival Date: {0}", form.adate));
            formInfo.Add(String.Format("Arrival Time: {0}", form.atime));
            formInfo.Add(String.Format("Room Type: {0}", form.room));
            formInfo.Add(String.Format("Number of Nights: {0}", form.numnights));
            formInfo.Add(String.Format("Number of Guests: {0}", form.numguest));
            if (!(String.IsNullOrEmpty(form.promo))) {
                formInfo.Add(String.Format("Promo Code: {0}", form.promo));
            }
            if (!(String.IsNullOrEmpty(form.notes))) {
                formInfo.Add(String.Format("Notes: {0}", form.notes));
            }
            return View("FormSubmitted", formInfo );
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
