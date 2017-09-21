using System;
using System.Collections.Generic;
using System.Text;
using OOPpractice;

namespace OOPpractice
{
    class OneYearAnniversary : Occasion
    {
        public override void AllPacked()
        {
            Console.WriteLine("All packed and ready to go!");
        }

        public override int TimeOff()
        {
            return 10;
        }

        public override int TransportationCost()
        {
            return 150;
        }

        public override bool Drinks()
        {
            return false;
        }
        public override string planeHasLanded()
        {
            return "Landed";
        }

        internal void Allpacked()
        {
            Console.WriteLine("All packed");
        }
    }
}
