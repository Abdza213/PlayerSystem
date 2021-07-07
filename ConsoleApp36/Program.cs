using ConsoleApp36.CreateGame;
using ConsoleApp36.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp36
{
    class Program
    {
        static Order order = new Order();
        static CampaingManeger campaingManeger = new CampaingManeger();
        static GamerManeger gamerManeger = new GamerManeger(new VerificationManeger() );
        static GameManeger gameManeger = new GameManeger(); 

        static void Main(string[] args)
        {

            // 1. player bilgileri
            Gamer gamer1 = new Gamer
            {
                GamerId ="3252dsfg",
                FullName = "Abdulrahim Za",
                NationalityID = "992343840251",
                Age = "18"
            };
            // bilgileri ekleme durumu 
            gamerManeger.Add(gamer1);

            //--------------

            //
            Game game1 = new Game
            {
                GameId = "42ds",
                GameName = "Call Of Duty",
                price = 200
            };
            //
            gameManeger.Add(game1);

            //--------------

            //
            Campaing campaing1 = new Campaing
            {
                CampaingId = "32g64",
                CampaingName = "trx",
                DisCount = 30.0
            };
            
            campaingManeger.Add(campaing1);
            //------------
            //
            order.Add(gamer1, game1, campaing1);

            //
            order.Delete(ref gamer1,ref game1,ref campaing1);


            Console.ReadKey();
        }
    }
}
