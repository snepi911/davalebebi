using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Product
    {
        public string Title;
        public string Description;
        public int Price;

        public double Priceinlari()
        {
            return Price * 2.62;
        }

    }

    
}
