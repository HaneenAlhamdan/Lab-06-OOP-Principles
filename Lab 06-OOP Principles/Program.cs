using System;

namespace Lab_06_OOP_Principles
{
    class Program
    {
        static void Main(string[] args)
        { 
         
            Console.WriteLine("Welcom in the Zoo!");
            //

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Leopard leopard = new Leopard("snoring");
        Console.Write("\n leopard say ");
            leopard.Eat();
            leopard.Sound();
            leopard.Hibernate();
            leopard.Hunt();
            Console.WriteLine(leopard.CanSwim());
          //

            //Console.ForegroundColor = ConsoleColor.DarkYellow;
            //Hawk hawk = new Hawk("Scream", "Meat", "Yellow");
            //Console.Write("\n Hawk say ");
            //hawk.Eat();
            //hawk.Sound();
            //hawk.BeakColor();
           // Console.WriteLine(hawk.CanSwim());

            //
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Turtle turtle = new Turtle("Hissing", "Vegetables");
            Console.Write("\n Turtle voice ");
            turtle.Sound();
            turtle.Eat();
            turtle.CanSwim();
            turtle.LayEggs();
            
           
        }
}
}
