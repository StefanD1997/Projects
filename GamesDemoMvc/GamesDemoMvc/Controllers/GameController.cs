using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GamesDemoMvc.DAL;
using GamesDemoMvc.Models;

namespace GamesDemoMvc.Controllers
{
    public class GameController : Controller
    {
        private IGameRepository gameRepository;
        private GameContext context;

        public GameController()
        {
            this.gameRepository = new GameRepository(new GameContext());
        }

        public GameController(IGameRepository gameRepository)
        {
            this.gameRepository = gameRepository;
        }

        // GET: Game
        public ActionResult Index(string sortOrder, string searchString)
        {

            ViewBag.NameSortParam = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewBag.DateSortParam = sortOrder == "Date" ? "date_desc" : "Date";
            ViewBag.PriceSortParam = sortOrder == "Price" ? "price_desc" : "Price";
            ViewBag.CategoriesSortParam = sortOrder == "Categories" ? "categories_desc" : "Categories";
            var games = from g in gameRepository.GetGames()
                        select g;

            if (!String.IsNullOrEmpty(searchString))
            {
                games = games.Where(n => n.gameName.Contains(searchString));
            }

            switch (sortOrder)
            {
                case "name_desc":
                    games = games.OrderByDescending(x => x.gameName);
                    break;
                case "Date":
                    games = games.OrderBy(x => x.gameReleaseDate);
                    break;
                case "date_desc":
                    games = games.OrderByDescending(x => x.gameReleaseDate);
                    break;
                case "price_desc":
                    games = games.OrderByDescending(x => x.gamePrice);
                    break;
                case "Price":
                    games = games.OrderBy(x => x.gamePrice);
                    break;
                case "categories_desc":
                    games = games.OrderByDescending(x => x.gameCategories);
                    break;
                case "Categories":
                    games = games.OrderBy(x => x.gameCategories);
                    break;
                default:
                    games = games.OrderBy(x => x.gameName);
                    break;
            }
            return View(games.ToList());
        }

        // GET: Game/Details/5
        public ActionResult Details(int id)
        {
            Game game = gameRepository.GetGamesByID(id);
            if (game == null)
            {
                return HttpNotFound();
            }
            return View(game);
        }

        // GET: Game/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Game/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "gameID,gamePicture,gameCategories,gamePrice,gameName,gameReleaseDate")] Game game)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    HttpPostedFileBase file = Request.Files["ImageData"];
                    int i = gameRepository.UploadImageInDataBase(file, game);
                    return RedirectToAction("Index");
                }
            }
            catch (Exception)
            {
                ModelState.AddModelError(string.Empty, "Unable To Save Changes. Try Again Later.");
            }
            return View(game);
        }

        // GET: Game/Edit/5
        public ActionResult Edit(int id)
        {
            Game game = gameRepository.GetGamesByID(id);
            if (game == null)
            {
                return HttpNotFound();
            }
            return View(game);
        }

        // POST: Game/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "gameID,gamePicture,gameCategories,gamePrice,gameName,gameReleaseDate")] Game game)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    gameRepository.UpdateGame(game);
                    gameRepository.Save();
                    return RedirectToAction("Index");
                }
            }
            catch (Exception)
            {
                ModelState.AddModelError(string.Empty, "Unable to Save Changes. Try Again Later.");
            }

            return View(game);
        }

        // GET: Game/Delete/5
        public ActionResult Delete(int id, bool? saveChangesError = false)
        {
            if (saveChangesError.GetValueOrDefault())
            {
                ViewBag.ErrorMessage = "Delete failed. Try again, and if the problem persists see your system administrator.";
            }
            Game game = gameRepository.GetGamesByID(id);
            if (game == null)
            {
                return HttpNotFound();
            }
            return View(game);
        }

        // POST: Game/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            try
            {
                Game game = gameRepository.GetGamesByID(id);
                gameRepository.DeleteGame(id);
                gameRepository.Save();
            }
            catch (Exception)
            {
                return RedirectToAction("Delete", new { id = id, saveChangesError = true });
            }
            return RedirectToAction("Index");
        }

        public ActionResult Upload()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UploadFile(HttpPostedFileBase file)
        {
            var mappedPath = HttpContext.Server.MapPath("~/Images/");
            if (file != null)
            {
                    file.SaveAs(Path.Combine(mappedPath, file.FileName));
            }
            return RedirectToAction("Index");
        }

        public ActionResult RetrieveImage(int id)
        {
            byte[] cover = GetImageFromDataBase(id);

            if (cover != null)
            {
                return File(cover, "image/jpg");
            }
            else
            {
                return null;
            }
        }

        public byte[] GetImageFromDataBase(int id)
        {
            var q = from g in context.Games where g.gameID == id select g.gamePicture;
            byte[] cover = q.First();
            return cover;
        }

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}
    }
}
