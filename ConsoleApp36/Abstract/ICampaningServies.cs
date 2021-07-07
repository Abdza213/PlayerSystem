using ConsoleApp36.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp36.Abstract
{
    public interface ICommenInterfaceServies
    {
        void Add(Campaing campaing);
        void Delete(ref Campaing campaing);
        void Update(ref Campaing campaing, Campaing campaing1);
    }
}
