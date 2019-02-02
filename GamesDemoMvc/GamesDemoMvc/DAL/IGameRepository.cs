using GamesDemoMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace GamesDemoMvc.DAL
{
    public interface IGameRepository
    {
        IEnumerable<Game> GetGames();
        Game GetGamesByID(int gameID);
        void InsertGame(Game game);
        void DeleteGame(int gameID);
        void UpdateGame(Game game);
        void Save();
        int UploadImageInDataBase(HttpPostedFileBase file, Game game);
    }
}
