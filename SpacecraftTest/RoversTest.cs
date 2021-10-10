using SpaceLibrary.Objects;
using System;
using System.Threading;
using Xunit;

namespace SpacecraftTest
{
    public class RoversTest
    {
        [Fact]
        public void Test_Scenario_Row1()
        {
            Assert.Equal("1 3 N", Rover.Instance.Run("1 2 N", "LMLMLMLMM", "5 5", false));
        }

        [Fact]
        public void Test_Scenario_Row2()
        {
            Assert.Equal("5 1 E", Rover.Instance.Run("3 3 E", "MMRMMRMRRM", "5 5", false));

        }

        [Fact]
        public void Test_Scenario_MultiThreaded()
        {
            Thread th1 = new Thread(Trigger1);
            th1.Start();
            Thread th2 = new Thread(Trigger2);
            th2.Start();

            Thread th3 = new Thread(Trigger1);
            th3.Start();
            Thread th4 = new Thread(Trigger2);
            th4.Start();

        }

        [Fact]
        private static void Trigger1()
        {
            Assert.Equal("1 3 N", Rover.Instance.Run("1 2 N", "LMLMLMLMM", "5 5", false));
        }

        [Fact]
        private static void Trigger2()
        {
            Assert.Equal("5 1 E", Rover.Instance.Run("3 3 E", "MMRMMRMRRM", "5 5", false));
        }

    }
}
