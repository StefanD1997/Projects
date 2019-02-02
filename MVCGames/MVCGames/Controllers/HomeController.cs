using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCGames.DAL;
using MVCGames.Models;

namespace MVCGames.Controllers
{
    public class HomeController : Controller
    {
        private GameContext db = new GameContext();


        public ActionResult Index()
        {
            var items = db.Categories.Select(x => x.ID).Distinct();

            if (items != null)
            {
                var data = new SelectList(db.Categories, "ID", "Name");

                List<SelectListItem> lists = new List<SelectListItem>();
                foreach (var item in data)
                {
                    lists.Add(item);
                }

                ViewBag.AllCategories = lists;
            }

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}