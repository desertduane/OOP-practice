﻿using System;
using System.Collections.Generic;
using System.Text;
using OOPpractice;

namespace OOPpractice
{
    class SpringBreak : Occasion //inheritance
    {
        public override void AllPacked()
        {
            Console.WriteLine("Packed up and ready to go!");
        }

        public override int TimeOff()
        {
            int daysOff = 7;
            return daysOff;
        }

        public override int TransportationCost()
        {
            int cost = 200;
            return cost;   
        }
        public override string planeHasLanded()
        {
            return "Landed";
        }
        public void vacationFunds() 
        {
           Console.WriteLine("My vacation funds are $500");
        }
    }
}
