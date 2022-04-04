using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_06_OOP_Principles
{
    public class Panda : Mammals
    {
        public override string sound { get; set; } = "Bleating";
        public override string eat { get; set; } = "Bamboo canes and mambo";

        public Panda(string sound, string eat)
        {
            this.sound = sound;
            this.eat = eat;
        }
        public override void Eat()
        {
            Console.WriteLine($"I eat {eat}");
        }

        public override string Hibernate()
        {
            return "I don't hibernate during winter";
        }

        public override string Sound()
        {
            return $" My sound is{this.sound}";
        }

    }
}
