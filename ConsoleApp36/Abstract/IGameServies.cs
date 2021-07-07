using ConsoleApp36.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp36.Abstract
{
    interface IGameServies
    {
        void Add(Game game);
        void Delete(ref Game game);
        void Update(Game game, Game game1);
    }
}
