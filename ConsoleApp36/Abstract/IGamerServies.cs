using ConsoleApp36.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp36.Abstract
{
    interface IGamerServies
    {
        void Add(Gamer gamer);
        void Delete(ref Gamer gamer);
        void Update(Gamer gamer, Gamer gamer1);
    }
}
