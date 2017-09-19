using System;
using System.Collections.Generic;
using System.Text;
using OOPpractice;

namespace OOPpractice
{
    abstract class Occasion : Destination //inheritance
    {
        public virtual bool Drinks() //polymorphism virtual here because not all occasions require alcohol
        {
            return true;
        }
       

    }
}
