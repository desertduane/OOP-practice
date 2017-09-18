using OOPpractice;
using System;

namespace OOP_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Spring Break Time!");

            SpringBreak springbreak = new SpringBreak();
            Console.WriteLine("I got " + springbreak.TimeOff() + " days off");

            Console.WriteLine("Plane ticket was $" + springbreak.TransportationCost());

            Console.WriteLine("Getting drinks tonight: " + springbreak.Drinks());

            Console.WriteLine("");

            OneYearAnniversary anniversary = new OneYearAnniversary();

            Console.WriteLine("One Year Anniverary is here.");

            Console.WriteLine("We got " + anniversary.TimeOff() + " days off!");

            Console.WriteLine("Our plane tickets were $" + anniversary.TransportationCost() + " each");

            Console.WriteLine("Are we getting drunk on our anniversary: " + anniversary.Drinks());


            Console.Read();
            
        }
    }
}
