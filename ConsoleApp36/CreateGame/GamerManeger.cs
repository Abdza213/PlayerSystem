using ConsoleApp36.Abstract;
using ConsoleApp36.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp36.CreateGame
{
     class GamerManeger : IGamerServies
    {
        IVerificationServies verificationServies;

        public GamerManeger(IVerificationServies verificationServies)
        {
            this.verificationServies = verificationServies;
        }

        public void Add(Gamer gamer)
        {
            if (verificationServies.CheckifrealPerson(gamer))
            {
                    Console.WriteLine("Gamer Id -:" + gamer.GamerId + '\n' +
                        "Nationality ID -: " + gamer.NationalityID + '\n' +
                        "Full Name -: " + gamer.FullName + '\n' +
                         "Age -: " + gamer.Age);
                
                    Console.WriteLine("---------------------" + "\n");
            }
            else
            {
                throw new Exception("There is an error in the information, Please try again");
            }
        }


        public void Delete(ref Gamer gamer)
        {
            Console.WriteLine("The Player  Has Been Removed { Id -: " + gamer.GamerId + " }");
            gamer.GamerId = null;
            gamer.NationalityID = null;
            gamer.FullName = null;
            gamer.Age = null;

        }

        public void Update(Gamer gamer, Gamer gamer1)
        {
            gamer1.GamerId = gamer.GamerId;
            gamer1.NationalityID = gamer.NationalityID;
            gamer1.FullName = gamer.FullName;
            gamer1.Age = gamer.Age;

            Console.WriteLine("Information has been Updated");
        }
    }
}
