using SpaceLibrary.Objects;
using System;
using System.Threading;

namespace MarsRoverConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Rover.Instance.Run("1 2 N", "LMLMLMLMM"));

            //Console.WriteLine(Rover.Instance.Run("3 3 E", "MMRMMRMRRM"));

            Thread th1 = new Thread(Trigger1);
            th1.Start();
            Thread th2 = new Thread(Trigger2);
            th2.Start();

            Thread th3 = new Thread(Trigger1);
            th3.Start();
            Thread th4 = new Thread(Trigger2);
            th4.Start();

            Console.ReadLine();
        }

        public static void Trigger1()
        {
            Console.WriteLine(Rover.Instance.Run("1 2 N", "LMLMLMLMM", "5 5", false));
        }

        public static void Trigger2()
        {
            Console.WriteLine(Rover.Instance.Run("3 3 E", "MMRMMRMRRM", "5 5", false));
        }
    }
}
