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
            ViewBag.Description = "<p>Based on<Strong> Marvel Comics'</Strong> superhero character," +
                                  " this is a story of <Strong>Peter Parker</Strong> who is a nerdy high school." +
                                  " He was orphaned as a child, bullied by jocks, and can't confess " +
                                  "his crush for his stunning neighborhood girl <Strong>Mary Jane Watson</Strong>." +
                                  " To say his life is is an understatement</p>";
            ViewBag.Authers = new string[]
            {
                "script : Alpha",
                "Pencil : HB Products",
                "Ink color : Jeown Library",
                "Writer : Nasir Khalil"
            };


            return View();
        }
    }
}