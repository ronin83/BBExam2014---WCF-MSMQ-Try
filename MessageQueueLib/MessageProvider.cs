using System;
using System.Collections.Generic;
using System.Linq;
using System.Messaging;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace MessageQueueLib
{
    public class MessageProvider
    {
        private const string mqName = @".\private$\syco";
        private MessageQueue mq;

        public MessageProvider( )
        {
            if (!MessageQueue.Exists(mqName))
            {
                MessageQueue.Create(mqName);
            }

            mq = new MessageQueue(@"FormatName:direct=os:" + mqName);
            mq.Formatter = new XmlMessageFormatter(new Type[] {typeof(repoItem)});
        }

        public repoItem GetItem()
        {
            var message = mq.Receive();
            return (repoItem) message.Body; 
        }


        public void InsertItem(repoItem item)
        {
            mq.Send(item);
        }

    } 
}
