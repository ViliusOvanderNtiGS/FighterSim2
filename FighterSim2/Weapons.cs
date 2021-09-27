using System;

namespace FighterSim2
{
    public class Weapons
    {
        public string WeaponName = "";

        Random generator = new Random();

        public string name = "";


        public int Damage()
        {

            int r = generator.Next(5, 25);

            return r;

        }

    }
}