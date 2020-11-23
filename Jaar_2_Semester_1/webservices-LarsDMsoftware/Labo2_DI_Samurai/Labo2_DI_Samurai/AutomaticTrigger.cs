using System;
using System.Collections.Generic;
using System.Text;

namespace Labo2_DI_Samurai
{
    class AutomaticTrigger : ITrigger
    {
        public void Pull()
        {
            Console.WriteLine("Automatically pulls trigger");
        }
    }
}
