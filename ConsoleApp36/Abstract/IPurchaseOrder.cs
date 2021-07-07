using ConsoleApp36.CreateGame;
using ConsoleApp36.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp36.Abstract
{
     interface IPurchaseOrder
    {
        void Add(Gamer gamer, Game game, Campaing campaing);
        void Delete(ref Gamer gamer, ref Game game, ref Campaing campaing);
    }
}
