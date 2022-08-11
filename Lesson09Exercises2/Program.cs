using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson09Exercises2
{
    class Supermarket //a
    {
        private string strSupermarketName = "Nice Supermarket";
        protected static int intCustomerCount;
        protected static float fltTotalSales;
        public string SupermarketName //b
        {
            get { return strSupermarketName; }
        }
        public Supermarket(string strSupermarketName)
        {
            this.strSupermarketName = strSupermarketName;
        }

        public static float FltTotalSales()
        {
            return fltTotalSales;
        }
        public static int IntCustomerCount()
        {
            return intCustomerCount;
        }
    }
    class Customer: Supermarket
    {
        private string strCustomerName;
        private float fltExpense;
        public Customer(string SupermarketName, string strCustomerName, float fltExpense): base(SupermarketName)
        {
            this.strCustomerName = strCustomerName;
            this.fltExpense = fltExpense;
            fltTotalSales += fltExpense;
            intCustomerCount++;
        }
        public string Get_info()
        {
            return "Super market name: " + SupermarketName+" customer name: " + strCustomerName;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer objC1, objC2;
            Console.Write("Enter 1st superMarket: ");
            string superMarket = Console.ReadLine();
            Console.Write("Enter 1st name: ");
            string name = Console.ReadLine();
            Console.Write("Enter 1st expense: ");
            float price = float.Parse(Console.ReadLine());
            objC1 = new Customer(superMarket,name, price);

            Console.Write("Enter 2nd superMarket: ");
            superMarket = Console.ReadLine();
            Console.Write("Enter 2nd name: ");
            name = Console.ReadLine();
            Console.Write("Enter 2nd expense: ");
            price = float.Parse(Console.ReadLine());
            objC2 = new Customer(superMarket, name, price);

            Console.WriteLine(objC1.Get_info());
            Console.WriteLine(objC2.Get_info());
            Console.WriteLine("Total customers: " + Supermarket.IntCustomerCount());
            Console.WriteLine("Total sales: "+Supermarket.FltTotalSales());
            Console.ReadKey();

        }
    }
}
