using Microsoft.SharePoint.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace CsomCrudOperations
{
    class CsomGetListItem
    {
        public void GetListItem()
        {
            User usr = new User();

            CamlQuery query = CamlQuery.CreateAllItemsQuery(100);
            ListItemCollection items = usr.userList.GetItems(query);

            // Retrieve all items in the ListItemCollection from List.GetItems(Query). 
            usr.context.Load(items);
            usr.context.ExecuteQuery();

            // Enumerate the web.Lists. 
            foreach (ListItem listItem in items)
            {
                Console.Write(listItem["ID"] +"    ");
                Console.Write(listItem["Title"] + "   ");
                Console.Write(listItem["UserAge"] + "    ");
                Console.Write(listItem["UserCity"] + "    ");
                Console.Write(listItem["UserCountry"] + "    ");
                Console.Write(listItem["UserName1"] + "   ");
                Console.Write(listItem["UserNumber"]);
                Console.WriteLine();
            }
            Console.WriteLine("Press any key...");
            Console.ReadLine();
        }
    }
}
