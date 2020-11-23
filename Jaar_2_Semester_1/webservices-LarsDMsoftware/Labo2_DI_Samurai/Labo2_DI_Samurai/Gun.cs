using System;
using System.Collections.Generic;
using System.Text;

namespace Labo2_DI_Samurai
{
    class Gun : ITrigger, IWeapon
    {
        //  Fields    //
        private ITrigger _trigger;


        public Gun(ITrigger trigger)
        {
            trigger = _trigger;
        }

        public void Hit(string target)
        {
            Console.WriteLine($"Target {target} has been hit.");
        }

        public void Pull()
        {

        }
    }
}
