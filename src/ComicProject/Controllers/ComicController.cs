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
            var comic = new Comic()
            {
                SeriesTitle = "The Amazing Spider Man",
                IssueNumber = 700,
                DescriptionHtml = "<p>Based on<Strong> Marvel Comics'</Strong> superhero character," +
                                  " this is a story of <Strong>Peter Parker</Strong> who is a nerdy high school." +
                                  " He was orphaned as a child, bullied by jocks, and can't confess " +
                                  "his crush for his stunning neighborhood girl <Strong>Mary Jane Watson</Strong>." +
                                  " To say his life is is an understatement</p>",
                Artists = new Artist[]
                {
                    new Artist() {Name = "script",Role = "Alpha"},
                    new Artist() {Name = "Pencil",Role = "HB Products"},
                    new Artist() {Name = "Ink color",Role = "eown Library"},
                    new Artist() {Name = "Writer",Role = "Nasir Khalil"}
                }

            };
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