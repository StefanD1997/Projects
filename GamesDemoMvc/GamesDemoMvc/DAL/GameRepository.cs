using GamesDemoMvc.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Web;

namespace GamesDemoMvc.DAL
{
    public class GameRepository : IGameRepository
    {
        private GameContext context;

        public GameRepository(GameContext _context)
        {
            this.context = _context;
        }

        public void DeleteGame(int gameID)
        {
            Game game = context.Games.Find(gameID);
            context.Games.Remove(game);
        }

        public IEnumerable<Game> GetGames()
        {
            return context.Games.ToList();
        }

        public Game GetGamesByID(int gameID)
        {
            return context.Games.Find(gameID);
        }

        public void InsertGame(Game game)
        {
            context.Games.Add(game);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void UpdateGame(Game game)
        {
            context.Entry(game).State = EntityState.Modified;
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public int UploadImageInDataBase(HttpPostedFileBase file, Game game)
        {
            game.gamePicture = ConvertToBytes(file);
            var Game = new Game
            {
                gamePicture = game.gamePicture,
                gameCategories = game.gameCategories,
                gamePrice = game.gamePrice,
                gameName = game.gameName,
                gameReleaseDate = game.gameReleaseDate
            };

            context.Games.Add(Game);
            int i = context.SaveChanges();
            if (i == 1)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public byte[] ConvertToBytes(HttpPostedFileBase image)
        {
            byte[] imageBytes = null;
            BinaryReader reader = new BinaryReader(image.InputStream);
            imageBytes = reader.ReadBytes((int)image.ContentLength);
            return imageBytes;
        }

        //public void UploadImageToFolder(HttpPostedFileBase file)
        //{
        //    string savePath = "C:/Users/Stefan/source/repos/GamesDemoMvc/GamesDemoMvc/Images";
        //    string fileName = file.FileName;
        //    string pathToCheck = savePath + fileName;
        //    string tempFileName = "";

        //    if (File.Exists(pathToCheck))
        //    {
        //        int cnt = 2;
        //        while (File.Exists(pathToCheck))
        //        {
        //            tempFileName = cnt.ToString() + fileName;
        //            pathToCheck = savePath + tempFileName;
        //            cnt++;
        //        }

        //        fileName = tempFileName;
        //    }
        //    else
        //    {

        //    }

        //    savePath += fileName;

        //    file.SaveAs(savePath);
        //}
    }
}