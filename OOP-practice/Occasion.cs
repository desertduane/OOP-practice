using System;
using System.Collections.Generic;
using System.Text;
using OOPpractice;

namespace OOPpractice
{
    abstract class Occasion : Destination
    {
        public virtual bool Drinks()
        {
            return true;
        }
       

    }
}
