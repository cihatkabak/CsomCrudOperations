using Microsoft.SharePoint.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace CsomCrudOperations
{
    class CsomUpdate
    {
        public void Update()
        {
            User usr = new User();

            CsomGetListItem g = new CsomGetListItem();

            Console.Write("Please enter the updated list item ID=");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter the Title=");
            string title = Console.ReadLine();
            Console.Write("Please enter the UserAge=");
            int UserAge = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter the UserCity=");
            string usercity = Console.ReadLine();
            Console.Write("Please enter the UserCountry=");
            string usercountry = Console.ReadLine();
            Console.Write("Please enter the UserName=");
            string username = Console.ReadLine();
            Console.Write("Please enter the UserNumber=");
            int usernumber = Convert.ToInt32(Console.ReadLine());
            // Assume there is a list item with ID=1. 
            ListItem listItem = usr.userList.GetItemById(id);

            listItem["Title"] = title;
            listItem["UserAge"] = UserAge;
            listItem["UserCity"] = usercity;
            listItem["UserCountry"] = usercountry;
            listItem["UserName1"] = username;
            listItem["UserNumber"] = UserAge;
            listItem.Update();

            usr.context.ExecuteQuery();
            Console.WriteLine("Succesfully Updated...");
            Console.Read();
        }
    }
}
