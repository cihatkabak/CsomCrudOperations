using Microsoft.SharePoint.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace CsomCrudOperations
{
    class CsomCreate
    {
        public void Create()
        {
            User usr = new User();

            // We are just creating a regular list item, so we don't need to 
            // set any properties. If we wanted to create a new folder, for 
            // example, we would have to set properties such as 
            // UnderlyingObjectType to FileSystemObjectType.Folder. 
            ListItemCreationInformation itemCreateInfo = new ListItemCreationInformation();
            ListItem newItem = usr.userList.AddItem(itemCreateInfo);

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

            newItem["Title"] = title;
            newItem["UserAge"] = UserAge;
            newItem["UserCity"] = usercity;
            newItem["UserCountry"] = usercountry;
            newItem["UserName1"] = username;
            newItem["UserNumber"] = usernumber;
            newItem.Update();

            usr.context.ExecuteQuery();
            Console.WriteLine("Successfully item created !");
            Console.Read();
        }
        
    }
}
