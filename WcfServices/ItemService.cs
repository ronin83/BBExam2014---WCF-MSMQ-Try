using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DataLayer;

namespace WcfServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ItemService" in both code and config file together.
    
    public class ItemService : IItemService
    {
        Repository repo = new Repository();

        public List<repoItem> GetAllItems()
        {
            return repo.getAllItems();
        }

        public void AddNewItem(repoItem item)
        {
            repo.AddItem(item);
        }
    }
}
