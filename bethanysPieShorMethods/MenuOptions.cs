using System;

namespace BethanysPieShopMethods
{
    public class Menu
    {

        //Methods

        public int DrawMenu()  //going to draw my menu of choices, contestant, sweep, winner
        {
            Console.WriteLine("The Custom List Menu");
            Console.WriteLine("------------------------------------");
            Console.WriteLine();
            Console.WriteLine("1. yearly wage");
            Console.WriteLine("2. pie production");
            Console.WriteLine("3. facility cubic feet");
            Console.WriteLine("4. facility sq feet");
            Console.WriteLine("5. customer name");
            Console.WriteLine("6. customer address");
            Console.WriteLine("7. previous order");

            bool invalidEntry = true; //this bool insures that an invalid entry is not entered
            string result = "";

            while (invalidEntry == true)
            {
                result = Console.ReadLine();

                if (isValidEntry(result) == true)
                {
                    invalidEntry = false;
                }
                else
                {
                    Console.WriteLine("Entry was incorrect, please enter 1-7");
                }
            }

            return int.Parse(result);
        }
        public bool isValidEntry(string result)
        {

            //This method will chck two things: 1) if th string can b pars to an int 2) if they entered an int - was the int 1-6 (EX: 15 is not a menu option)
            int number;
            bool isNumeric = int.TryParse(result, out number); //This is a method that checks if a string can be parsed into a int. EX: "2" - this would return TRUE, EX: "greg" this would return FALSE

            if (isNumeric == true)
            {
                if (number < 19 && number > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public void DirectUser(int option)
        {
            Console.Clear();

            switch (option)
            {
                case 1:
                    EmployeeWage switchCaseObject = new EmployeeWage();
                    switchCaseObject.CalculateYearlyWage();
                    Console.ReadLine();
                    break;
                case 2:
                    PieShopOperations_Pie_Production something = new PieShopOperations_Pie_Production();
                    something.Pie_Production();
                    Console.ReadLine();
                    break;
                case 3:
                    PieShopDimensions cubicFootage = new PieShopDimensions();
                    cubicFootage.PieShopCubicFootage();
                    Console.ReadLine();
                    break;
                case 4:
                    PieShopDimensions sqFootage = new PieShopDimensions();
                    sqFootage.PieShopSquareFootage();
                    Console.ReadLine();
                    break;
                case 5:
                    PieShopCustomer getName = new PieShopCustomer();
                    getName.GetShopCustomerName();
                    Console.ReadLine();
                    break;
                case 6:
                    PieShopCustomer getAddress = new PieShopCustomer();
                    getAddress.GetShopCustomerAddress();
                    Console.ReadLine();
                    break;
                case 7:
                    PieShopCustomer getPreviousOrders = new PieShopCustomer();
                    getPreviousOrders.GetShopCustomerPreviousOrders();
                    Console.ReadLine();
                    break;
                default:
                    break;
            }
        }
    }
}
