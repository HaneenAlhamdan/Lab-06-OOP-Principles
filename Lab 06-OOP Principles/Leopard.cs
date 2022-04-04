using System;
using System.Collections.Generic;
using System.Text;
using Lab_06_OOP_Principles.Interface;

namespace Lab_06_OOP_Principles
{

     public class Leopard : Mammals, Swim, Walk
    {
        public override string sound { get; set; } = "snoring";
        public override string eat { get; set; } = "Meat";

        public Leopard(string sound)
        {
            this.sound = sound;
        }

        public override void Eat()
        {
            Console.WriteLine($"I eat {this.eat}");
        }

        public override string Hibernate()
        {
            return "I don't need to hibernate";
        }

        public override string Sound()
        {
            return $"My sound is {this.sound}";
        }

        public override void Hunt()
        {
            
            Console.WriteLine("I am a hunter");
        }

        public string CanSwim()
        {
            return "I can swim";
        }

        public string CanWalk()
        {
            return "I can Walk very fast";
        }
    }
}
