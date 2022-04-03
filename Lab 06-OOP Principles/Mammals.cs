using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_06_OOP_Principles
{
    
    public abstract class Mammals : Animals
    {
        public bool HasFur { get; set; }

        public abstract string Hibernate();

        public virtual void Hunt()
        {
            Console.WriteLine("Where is my food?");
        }

        public string KeepWarm(bool fur)
        {
            return "This fur keeps me warm :D";
        }
    }
}
