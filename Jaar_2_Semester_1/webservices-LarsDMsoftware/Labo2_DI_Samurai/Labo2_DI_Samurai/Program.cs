using System;

namespace Labo2_DI_Samurai
{
    class Program
    {
        static void Main(string[] args)
        {
            Gun pistol = new Gun(new AutomaticTrigger());
            Samurai firstSamurai = new Samurai(new Gun(pistol));

            firstSamurai.Attack("Someone");

        }
    }
}
