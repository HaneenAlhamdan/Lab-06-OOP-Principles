using System;
using System.Collections.Generic;
using System.Text;
using Lab_06_OOP_Principles.Interface;

namespace Lab_06_OOP_Principles
{
    
   public class Turtle : Reptile, Swim
    {
        public override string sound { get; set; } = "Hissing";
        public override string eat { get; set; } = "Vegetables";

        public Turtle(string sound, string eat)
        {
            this.sound = sound;
            this.eat = eat;
        }

        public string CanSwim()
        {
            return "I can swim ";
        }
        public string CanWalk()
        {
            return "I Can Walk ";
        }

        public override void Eat()
        {
            Console.WriteLine($"I eat {this.eat}");
        }

        public override void LayEggs()
        {
            Console.WriteLine("I lay eggs");
        }

        public override string Sound()
        {
            return $"{this.sound}";
        }
    }
}
