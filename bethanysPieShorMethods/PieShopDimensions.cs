using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanysPieShopMethods
{ 
    class PieShopDimensions
    {
        int length = 4;
        int width = 2;
        int height = 3;
        public void PieShopCubicFootage()
        {
            int cubicFeet = length * width * height;
            Console.WriteLine($"Cubic feet: {cubicFeet}");
            Console.ReadLine();
        }

        public void PieShopSquareFootage()
        {
            int squareFootage = length * width;
            Console.WriteLine($"multiply two variables to get shop sqFT: {squareFootage}");
            Console.ReadLine();

        }
    }
}
