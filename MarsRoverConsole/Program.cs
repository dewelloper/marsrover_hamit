using SpaceLibrary.Objects;
using System;

namespace MarsRoverConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(new Rover(5,5).Run("1 2 N", "LMLMLMLMM"));

            Console.WriteLine(new Rover(5, 5).Run("3 3 E", "MMRMMRMRRM"));

            Console.ReadLine();
        }
    }
}
