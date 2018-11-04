using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicProject.Controllers
{
    public class ComicController : Controller
    {
        public ActionResult Detail()
        {
            //if (DateTime.Today.DayOfWeek == DayOfWeek.Friday)
            //{
            //    return Redirect("/");
            //}
            ViewBag.SeriesTitle = "The Amazing Spider Man";
            ViewBag.ItemNumber = 700;
            ViewBag.Description = "<p>this si the paragraph which I wrote first time during...<strong>programing of ASP.NET</strong></p>";
            ViewBag.Authers = new string[]
            {
                "script : ABC",
                "Pencil : GHI",
                "Ink color : JKL",
                "Writer : MNO"
            };


            return View();
        }
    }
}