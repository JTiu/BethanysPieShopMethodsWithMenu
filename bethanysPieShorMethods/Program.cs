using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanysPieShopMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu startMenu = new Menu();
            int optionPicked;
            optionPicked = startMenu.DrawMenu(); //

            while (optionPicked != 19)
            {
                Console.Clear();
                startMenu.DirectUser(optionPicked);
                Console.Clear();
                optionPicked = startMenu.DrawMenu();
            }

            Console.WriteLine("Press any button to exit application");
        }
    }
}
