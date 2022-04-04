using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_06_OOP_Principles
{

    public class Hawk : Birds
    {
        public override bool canFly { get; set; } = true;
        public override string sound { get; set; } = "Scream";
        public override string eat { get; set; } = "Meat";
        public override string beakColor { get; set; } = "Yellow";

        public Hawk(bool canFly, string sound, string eat, string beakColor)
        {
            this.canFly = canFly;
            this.sound = sound;
            this.eat = eat;
            this.beakColor = beakColor;
        }

        public override string BeakColor()
        {
            return $"My beak color is {beakColor}";
        }

        public override void Eat()
        {
            Console.WriteLine("I eat meat");
        }

        public override bool Fly(bool canfly)
        {
            return base.Fly(canFly);
           // Console.WriteLine("i can"{canFly});
        }

        public override string Sound()
        {
            return $"My sound is {this.sound}";
        }
    }
}
