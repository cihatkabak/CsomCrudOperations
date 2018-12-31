using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsomCrudOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("For get list item press '1',for create list item press '2',for update list item press '3',for delete list item press '4' ");
            string a = Console.ReadLine();
            if (a == "1")
            {
                CsomGetListItem g = new CsomGetListItem();
                g.GetListItem();
            }
            else if (a == "2")
            {
                CsomCreate c = new CsomCreate();
                c.Create();
            }
            else if (a == "3")
            {
                CsomUpdate u = new CsomUpdate();
                u.Update();
            }
            else if (a == "4")
            {
                CsomDelete d = new CsomDelete();
                d.Delete();
            }
            else
            {
                Console.WriteLine("Please press 1,2,3 or 4 !");
                Program p = new Program();
            }
        }
    }
}
