using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanysPieShopMethods
{
    public class PieShopOperations_Pie_Production
    {
        public void Pie_Production()
        {
            int piesPerMonth = 5;
            int months = 6;
            PieShopOperations_Pie_Production this2 = new PieShopOperations_Pie_Production();
            Console.WriteLine($"multiply two variables to get pie production: {piesPerMonth * months}");
            Console.ReadLine();
            
        }
    }
}
