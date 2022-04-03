using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_06_OOP_Principles
{
   public abstract class Reptile : Animals
    {
        public abstract void LayEggs();

        public virtual String Food()
        {
            return "Food";
        }
    }
}
