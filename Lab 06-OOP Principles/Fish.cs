using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_06_OOP_Principles
{
    public abstract class Fish : Animals
    {
       
        public abstract class Dolphin
        {
            public abstract string Color();
        }
        public class whitedolphin : Dolphin
        {
            public override string Color()
            {
                return "im Dolphin my color is white";
            }
        }        }    }    
