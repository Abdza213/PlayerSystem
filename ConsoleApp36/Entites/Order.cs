using ConsoleApp36.Abstract;
using ConsoleApp36.CreateGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp36.Entites
{
    class Order : IPurchaseOrder
    {

        public void Add(Gamer gamer, Game game, Campaing campaing)
        {
            Console.WriteLine("  ~~ Some Important Information ~~ ");
            Console.WriteLine("Player Name -: " + gamer.FullName + '\n' + "Id -: " + gamer.GamerId);
            Console.WriteLine("-----------------------");
            Console.WriteLine("Game Name -: " + game.GameName + '\n' + "Id -: " + game.GameId);
            Console.WriteLine("-----------------------");
            Console.WriteLine("Campaing Name -: " + campaing.CampaingName + '\n' + "Id -: " + campaing.CampaingId);
            Console.WriteLine("-----------------------");
            double new_price = game.price - (game.price * campaing.DisCount / 100);
            Console.WriteLine("Old Price : " + game.price);
            Console.WriteLine("New Price (DisCount %" + campaing.DisCount + ") : " + new_price);

            Console.WriteLine("--------------------------");
        }

        public void Delete(ref Gamer gamer, ref Game game, ref Campaing campaing)
        {
            string a = gamer.GamerId;
            campaing.CampaingId = null;
            campaing.CampaingName = null;
            campaing.DisCount = 0.0;
            //
            game.GameId = null;
            game.GameName = null;
            game.price = 0;
            //
            gamer.GamerId = null;
            gamer.NationalityID = null;
            gamer.FullName = null;
            gamer.Age = null;

            Console.WriteLine("Player Purchase Order Has Been Removed { Id -: " + a + " }");
        }
    }
}
