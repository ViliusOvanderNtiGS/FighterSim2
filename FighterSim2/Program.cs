using System;

namespace FighterSim2
{
    class Program
    {
        static void Main(string[] args)
        {
            Fighter player = new Fighter();
            Fighter opponent = new Fighter();
            Weapons pWeapon = new Weapons();
            Weapons oWeapon = new Weapons();

            player.name = "bolgor";
            opponent.name = "golvor";

            System.Console.WriteLine("Fighter Sim:2");
            System.Console.WriteLine();
            System.Console.WriteLine("Vad heter du?");
            player.name = Console.ReadLine();
            System.Console.WriteLine("Vad heter din fiende?");
            opponent.name = Console.ReadLine();
            Console.Clear();

            System.Console.WriteLine("Vad heter ditt vapen?");
            pWeapon.name = Console.ReadLine();
            System.Console.WriteLine("Vad heter din fiendes vapen?");
            oWeapon.name = Console.ReadLine();
            Console.Clear();

            while (player.hp >= 0 && opponent.hp >= 0)
            {
                int oDamage = oWeapon.Damage();
                int pDamage = pWeapon.Damage();

                player.hp = player.hp - oDamage;
                opponent.hp = opponent.hp - pDamage;

                System.Console.WriteLine(player.name + " använder " + pWeapon.name + " och gör " + oDamage + " skada mot " + opponent.name);
                System.Console.WriteLine(opponent.name + " använder " + oWeapon.name + " och gör " + pDamage + " skada mot " + player.name);
                System.Console.WriteLine(player.name + " har nu " + player.hp + " hp kvar.");
                System.Console.WriteLine(opponent.name + " har kvar " + opponent.hp + " hp kvar.");
                Console.ReadLine();
                Console.Clear();

            }

            if (player.hp > opponent.hp)
            {
                Console.WriteLine(player.name + " vann!");
                Console.WriteLine(opponent.name + " luktar");
            }
            if (player.hp < opponent.hp)
            {
                Console.WriteLine(opponent.name + " vann!");
                Console.WriteLine(player.name + " luktar");
            }
            if (player.hp == opponent.hp)
            {
                Console.WriteLine("Ingen vann");
                Console.WriteLine("Båda luktar");
            }

            Console.ReadLine();


        }
    }
}
