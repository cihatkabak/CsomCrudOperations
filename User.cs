using Microsoft.SharePoint.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace CsomCrudOperations
{
    class User
    {
        public string userName { get; }
        public string password { get; }
        public ClientContext context { get; }
        public List userList { get; }
        public User()
        {
            
            userName = "abc@abc.com";//write sharepoint username
            password = "pass";//write sharepoint password
            
            context = new ClientContext("https://abc.sharepoint.com/sites/abc");//write site url
            SecureString passWord = new SecureString();
            foreach (char c in password.ToCharArray()) passWord.AppendChar(c);
            context.Credentials = new SharePointOnlineCredentials(userName, passWord);
            userList = context.Web.Lists.GetByTitle("User");//write List Name
        }
    }
}
