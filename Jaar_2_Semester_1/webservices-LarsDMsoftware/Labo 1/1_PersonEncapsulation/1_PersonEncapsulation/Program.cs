using System;

namespace _1_PersonEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Person persoon = new Person("Lars", "De Maere", new DateTime(1990,1,1)) ;
            Console.WriteLine(persoon.ToString());
        }
    }
}
