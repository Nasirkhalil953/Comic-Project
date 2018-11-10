using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ComicProject.Data;
using ComicProject.Models;

namespace ComicProject.Controllers
{
    public class ComicController : Controller
    {
        private ComicRepository _comicRepository = null;

        public ComicController()
        {
            _comicRepository = new ComicRepository();
        }

        public ActionResult Index()
        {
            var comic = _comicRepository.GetComics();
            return View(comic);
        }

        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            var comic = _comicRepository.GetComic((int)id);
            


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