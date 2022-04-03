using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Lab_06_OOP_Principles.Interface;

namespace Lab_06_OOP_Principles
{

    public abstract class Birds : Animals
    {
        abstract public bool canFly { get; set; }
        abstract public string beakColor { get; set; }

        //public override void Wings()
        //{
        //    base.Wings();
        //}

        public abstract string BeakColor();

        public virtual bool Fly(bool canfly)
        {
            if (canFly)
            {
                Console.WriteLine("I can fly");
                return true;
            }
            else
            {
                Console.WriteLine("I Can't fly");
                return false;
            }
        }
    }

}

