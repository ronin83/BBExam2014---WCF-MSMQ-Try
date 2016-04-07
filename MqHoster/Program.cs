using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MessageQueueLib;

namespace MqHoster
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var mq = new MessageProvider();

                var item = mq.GetItem();

                var repo = new DataLayer.Repository();

                repo.AddItem(item);
            }
        }
    }
}
