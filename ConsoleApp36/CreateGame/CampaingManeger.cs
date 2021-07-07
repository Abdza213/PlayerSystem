using ConsoleApp36.Abstract;
using ConsoleApp36.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp36.CreateGame
{
    public class CampaingManeger : ICommenInterfaceServies
    {
        public void Add(Campaing campaing)
        {
            Console.WriteLine("Compaing Id -:" +campaing.CampaingId + '\n' + 
                "Compaing Name -: " + campaing.CampaingName + '\n' + 
                "Comaing DisCount -: "+ campaing.DisCount);
            Console.WriteLine("---------------------" + "\n");
        }

        public void Delete(ref Campaing campaing)
        {
            Console.WriteLine("The Game Discount Has Been Deleted { Id -: " + campaing.CampaingId + " }");
            campaing.CampaingId = null;
            campaing.CampaingName = null;
            campaing.DisCount = 0.0;
        }

        public void Update(ref Campaing campaing, Campaing campaing1)
        {
            campaing1.CampaingName = campaing.CampaingName;
            campaing1.CampaingId = campaing.CampaingId;
            campaing1.DisCount = campaing.DisCount;
            Console.WriteLine("Information has been Updated");
        }
    }
}
