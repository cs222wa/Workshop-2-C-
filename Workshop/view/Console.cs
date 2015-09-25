using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop.view
{
    class Console
    {
        public void Start()
        {
            System.Console.WriteLine("Press any key to view menu, q to quit.");
        }

        public bool Continue()
        {
            return System.Console.ReadKey().KeyChar != 'q';
        }
       
         public int ViewMenu()           
        {
            System.Console.Clear();
            System.Console.WriteLine("MENU:");
            System.Console.WriteLine("1. Register new member");
            System.Console.WriteLine("2. Edit member");
            System.Console.WriteLine("3. Delete member");
            System.Console.WriteLine("4. Register boat");
            System.Console.WriteLine("5. Edit boat");
            System.Console.WriteLine("6. Delete boat");
            System.Console.WriteLine("7. View member");
            System.Console.WriteLine("\t7a. View member - 'compact list'");     //ÄNDRA
            System.Console.WriteLine("\t7b. View member - 'verbose list'");     //ÄNDRA
            System.Console.WriteLine("\t7c. View detail");                      //ÄNDRA

            return int.Parse(System.Console.ReadLine());
        }

         public void ConfirmChange(string prompt)
         {
             System.Console.WriteLine(prompt);
         }
         
        public string RegisterName()
         {
             System.Console.Clear();
             System.Console.WriteLine("REGISTER MEMBER");
             System.Console.WriteLine("Name: ");
             return System.Console.ReadLine();
         }

        public int RegisterPersonalIdentityNumber()
        {
            System.Console.WriteLine("Personal identity number: ");
            return int.Parse(System.Console.ReadLine());
        }

        public void EditMember()
        {
            System.Console.WriteLine("Test editmember");
        }
    }
}
