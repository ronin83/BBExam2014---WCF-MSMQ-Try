using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Repository
    {
        SycoPreperationEntities entities = new SycoPreperationEntities();

        public List<repoItem> getAllItems()
        {
            List<repoItem> result = new List<repoItem>();
            var itemsInDB = entities.Items.ToList();

            foreach (var x in itemsInDB)
            {
                repoItem repoItem = new repoItem(
                    Guid.NewGuid().GetHashCode(),
                    x.Description,
                    x.Price,
                    x.Amount,
                    x.Category);
                
                result.Add(repoItem);
            }
            return result;
        }

        public void AddItem(repoItem item)
        {
            

            entities.Items.Add(new Item()
            {
                Id = Guid.NewGuid().GetHashCode(),
                Amount = item.Amount,
                Category = item.Category,
                Description = item.Description,
                Price = item.Price,
            });

            

            entities.SaveChanges();
        }
    }
}
