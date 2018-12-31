using Microsoft.SharePoint.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace CsomCrudOperations
{
    class CsomDelete
    {
        public void Delete()
        {
            User usr = new User();
            
            CsomGetListItem g = new CsomGetListItem();

            Console.Write("Please enter the deleted list item ID=");
            int id = Convert.ToInt32(Console.ReadLine());

            ListItem listItem = usr.userList.GetItemById(id);
            listItem.DeleteObject();

            usr.context.ExecuteQuery();
        }
    }
    
}
