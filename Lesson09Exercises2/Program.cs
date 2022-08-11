using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson09Exercises2
{
    class Supermarket
    {
        private string strSupermarketName = "Nice Supermarket";
        protected static int intCustomerCount;
        protected static float fltTotalSales;
        public string SupermarketName //b
        {
            get { return strSupermarketName; }
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
