using ConsoleApp36.Abstract;
using ConsoleApp36.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp36.CreateGame
{
    public class GameManeger : IGameServies
    {
        public void Add(Game game)
        {
            Console.WriteLine("Game Id -:" + game.GameId + '\n' +
              "Game Name -: " + game.GameName + '\n' +
              "Game Price -: " + game.price);
            Console.WriteLine("---------------------" + "\n");
        }

        public void Delete(ref Game game)
        {
            Console.WriteLine("The Game Has Been Deleted { Id -: " + game.GameId + " }");
            game.GameId = null;
            game.GameName = null;
            game.price = 0;
        }

        public void Update(Game game, Game game1)
        {
            game1.GameId = game.GameId;
            game1.GameName = game.GameName;
            game.price = game.price;
            Console.WriteLine("Information has been Updated");
        }
    }
}
