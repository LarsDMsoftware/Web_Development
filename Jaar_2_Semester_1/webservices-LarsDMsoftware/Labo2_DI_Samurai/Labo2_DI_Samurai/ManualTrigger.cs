using System;
using System.Collections.Generic;
using System.Text;

namespace Labo2_DI_Samurai
{
    class ManualTrigger : ITrigger
    {
        public void Pull()
        {
            Console.WriteLine("You have to manually pull the trigger.");
        }
    }
}
