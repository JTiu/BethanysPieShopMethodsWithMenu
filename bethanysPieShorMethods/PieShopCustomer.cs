using System;

namespace BethanysPieShopMethods
{
    class PieShopCustomer
    {
        string name = "JT";
        string address = "123 Mockingbird Lane";
        string previousOrder = "apple";
        public void GetShopCustomerName()
        {
            Console.WriteLine($"This is the customer name: {name}");
        }
        public void GetShopCustomerAddress()
        {
            Console.WriteLine($"This is the customer address: {address}");
        }
        public void GetShopCustomerPreviousOrders()
        {
            Console.WriteLine($"This is the previous order: {previousOrder}");
        }
    }
}
