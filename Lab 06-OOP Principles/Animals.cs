using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Lab_06_OOP_Principles.Interface;

namespace Lab_06_OOP_Principles
{
   
        public abstract class Animals
        {
            abstract public string sound { get; set; }
            abstract public string eat { get; set; }

            public abstract void Eat();

            public abstract string Sound();

            public virtual void Fins()
            {
                Console.WriteLine("I have a fins");
            }
        public virtual void Wings()
        {
            Console.WriteLine("I have a wings");
        }
    }
    
}
