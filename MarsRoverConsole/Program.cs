using SpaceLibrary.Objects;
using System;

namespace MarsRoverConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Rover.Instance.Run("1 2 N", "LMLMLMLMM"));

            Console.WriteLine(Rover.Instance.Run("3 3 E", "MMRMMRMRRM"));

            Console.ReadLine();
        }
    }
}
