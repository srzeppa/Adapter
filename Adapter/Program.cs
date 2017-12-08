using System;

namespace Adapter
{
    class Program
    {
        static void Main()
        {
            var specificPlayer = new SpecificPlayer();
            Console.WriteLine(specificPlayer.GetSpecificPlayer());

            Console.ReadKey();
        }
    }
}
