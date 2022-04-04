using System;
using System.Collections.Generic;
using System.Text;
using Lab_06_OOP_Principles.Interface;

namespace Lab_06_OOP_Principles
{

        public class Dolphin : Fish
    {
        public override string sound { get; set; } = "whistling";
        public override string eat { get; set; } = "Small fishs";

        public Dolphin(string sound, string eat)
        {
            this.sound = sound;
            this.eat = eat;
        }
        public string CanSwim()
        {
            return "I Can Swim";
        }

        public override string Sound()
        {
            return $"My sound is {this.sound}";
        }
        public override void Eat()
        {
            Console.WriteLine($"I eat {eat}");
        }
       
    }
}
