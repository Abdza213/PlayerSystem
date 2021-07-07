using ConsoleApp36.Abstract;
using ConsoleApp36.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp36.CreateGame
{
    class VerificationManeger : IVerificationServies
    {
        public bool CheckifrealPerson(Gamer gamer)
        {
            

            if (gamer.FullName != string.Empty && gamer.GamerId != string.Empty && gamer.Age != string.Empty && gamer.NationalityID.Length == 11 )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
