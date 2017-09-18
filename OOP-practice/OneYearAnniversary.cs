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
    }
}
