using System;

namespace ObjectAdapter
{
    class Program
    {
        static void Main()
        {

            var player = new SpecificPlayer("Jan", "Nowak", 25);
            Console.WriteLine(player.GetSpecificPlayer());

            Console.ReadLine();

        }
    }
}
