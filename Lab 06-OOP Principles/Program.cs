using System;

namespace Lab_06_OOP_Principles
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Welcom in the Zoo!");
            //

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Leopard leopard = new Leopard("snoring");
            Console.Write("\n leopard say ");
            leopard.Eat();
            leopard.Sound();
           // leopard.Hibernate();
           // leopard.Hunt();
            Console.WriteLine(leopard.CanSwim());
            //

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Hawk hawk = new Hawk(true,"Scream", "Meat", "Yellow");
            Console.Write("\n Hawk say ");
            hawk.Eat();
            hawk.Sound();
            hawk.BeakColor();
          //  Console.WriteLine(hawk.c());

            //
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Turtle turtle = new Turtle("Hissing", "Vegetables");
            Console.Write("\n Turtle ");
            turtle.Sound();
            turtle.Eat();
            turtle.CanSwim();
            turtle.LayEggs();

            //
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Panda bear = new Panda("snoring", "Bamboo canes and mambo");
            Console.Write("\n Panda say ");
            leopard.Eat();
            leopard.Sound();

            //
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Dolphin dolphin = new Dolphin("whistling", "Small fishs");
            Console.Write("\n Dolphin say ");
            leopard.Sound();
            leopard.Eat();

            //
            Console.ForegroundColor = ConsoleColor.White;


        }
}
}
