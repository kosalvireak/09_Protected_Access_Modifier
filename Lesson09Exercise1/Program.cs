using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson09Exercise1
{
    class Cinema
    {
        private string strCinemaName;
        protected static int intTicketSold;
        protected static int intTicketSales = 0;
        public string CinemaName //b
        {
            get { return strCinemaName; }
        }
        public Cinema(string strCinemaName) //c
        {
            this.strCinemaName = strCinemaName;
        }
        public static int TicketSold()
        { 
            return intTicketSold; 
        }
        public static int getTicketPrice()
        {
            return intTicketSales;
        }
    }
    class Ticket : Cinema
    {
        private string strMovie;
        private float fltTicketPrice; //d
        public string Movie
        {
            get { return strMovie; }
        }
        public float FltTicketPrice
        {
            get { return fltTicketPrice; }
        }
        public Ticket(string strMovie, float fltTicketPrice, string strCinemaName) : base(strCinemaName)
        {
            this.strMovie = strMovie;
            this.fltTicketPrice = fltTicketPrice;
            int intTicketPrice = (int)Math.Round(fltTicketPrice);
            intTicketSales += intTicketPrice;
            intTicketSold ++;
        } //e

        

    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Ticket objT1, objT2;
            Console.WriteLine("Enter the cinema 1: ");
            string cinema = Console.ReadLine();
            Console.WriteLine("Enter the movie 1: ");
            string movie = Console.ReadLine();
            Console.WriteLine("Enter the price 1: ");
            float price = float.Parse(Console.ReadLine());
            objT1 = new Ticket(cinema, price, movie);


            Console.WriteLine("Enter the cinema 2: ");
            cinema = Console.ReadLine();
            Console.WriteLine("Enter the movie 2: ");
            movie = Console.ReadLine();
            Console.WriteLine("Enter the price 2: ");
            price = float.Parse(Console.ReadLine());
            objT2 = new Ticket(cinema, price, movie);

            Console.WriteLine("Cinema name: {0}", objT1.Movie);
            Console.WriteLine("Cinema name: {0}", objT2.Movie);

            Console.WriteLine("Total ticket sold: "+ Cinema.TicketSold().ToString());
            Console.WriteLine("Total ticket sold in price is : "+ Cinema.TicketSold().ToString());
            Console.WriteLine("Total ticket sold in price is : "+ Cinema.getTicketPrice().ToString());

            Console.ReadKey();
        }
    }
}
