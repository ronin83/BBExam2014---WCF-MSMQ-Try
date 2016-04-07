using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    [DataContract]
    public class repoItem
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public int Price { get; set; }
        [DataMember]
        public int Amount { get; set; }
        [DataMember]
        public string Category { get; set; }


        public repoItem(int id, string description, int price, int amount, string category)
        {
            this.Id = id;
            this.Amount = amount;
            this.Category = category;
            this.Price = price;
            this.Description = description;
        }

        public repoItem()
        {
            
        }

    }
}
