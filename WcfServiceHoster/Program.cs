using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WcfServices;

namespace WcfServiceHoster
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(ItemService), new Uri(@"http://localhost:8099/ItemServiceFTW"));
            host.Open();

            Console.WriteLine("Service Hoster start...");

            Console.ReadLine();
        }
    }
}
