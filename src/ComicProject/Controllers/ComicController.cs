using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ComicProject.Models;

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
            //ViewBag.SeriesTitle = "";
            //ViewBag.ItemNumber = ;
            //ViewBag.Description = ";
            //ViewBag.Authers = new string[]
            //{
            //    "script : Alpha",
            //    "Pencil : HB Products",
            //    "Ink color : Jeown Library",
            //    "Writer : Nasir Khalil"
            //};

            return View(comic);
        }
    }
}