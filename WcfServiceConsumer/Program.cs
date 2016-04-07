using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfServiceConsumer.ISR;
using repoItem = DataLayer.repoItem;

//using WcfServiceConsumer.ISR;


namespace WcfServiceConsumer
{
    public class Program
    {
        static void Main(string[] args)
        {
            // was used before the message queue
            //ISR.ItemServiceClient isc = new ItemServiceClient();
            
            //var result = isc.GetAllItems().ToList();

            var newItem = new repoItem() { Id = Guid.NewGuid().GetHashCode(), Description = "BBB", Price = 99, Amount = 1, Category = "AAA" };

            var mq = new MessageQueueLib.MessageProvider();

            mq.InsertItem(newItem);

            // was used before the MSMQ - 
            //try
            //{
            //    isc.AddNewItem(newItem);

            //}
            //catch (Exception ex)
            //{

            //    throw new System.ServiceModel.FaultException(ex.Message);
            //}

            //Console.ReadLine();

        }
    }
}
