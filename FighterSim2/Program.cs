using System;

namespace FighterSim2
{
    class Program
    {
        static void Main(string[] args)
        {
            Fighter player = new Fighter();
            Fighter opponent = new Fighter();

            player.name = "bolgor";
            opponent.name = "golvor";

            System.Console.WriteLine("Fighter Sim:2");
            System.Console.WriteLine();
            System.Console.WriteLine("Vad heter du?");
            player.name = Console.ReadLine();
            System.Console.WriteLine("Vad heter din fiende?");
            opponent.name = Console.ReadLine();
            Console.Clear();




            // while (true)
            // {

            // }

        }
    }
}
