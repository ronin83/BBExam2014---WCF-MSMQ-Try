using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using DataLayer;

namespace AsmxSerivces
{
    /// <summary>
    /// Summary description for AsmxItemService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class AsmxItemService : System.Web.Services.WebService
    {

        
        Repository repo = new Repository();
        [WebMethod]
        public List<repoItem> GetAllItems()
        {
            return repo.getAllItems();
        }
        [WebMethod]
        public void AddItem(repoItem item)
        {
            repo.AddItem(item);
        }
    }
}
