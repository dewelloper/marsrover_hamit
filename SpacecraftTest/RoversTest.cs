using SpaceLibrary.Objects;
using System;
using Xunit;

namespace SpacecraftTest
{
    public class RoversTest
    {
        [Fact]
        public void Test_Scenario_Row1()
        {
            Grid.MaxXBound = 5;
            Grid.MaxYBound = 5;

            Assert.Equal("1 3 N", Rover.Instance.Run("1 2 N", "LMLMLMLMM"));
        }

        [Fact]
        public void Test_Scenario_Row2()
        {
            Grid.MaxXBound = 5;
            Grid.MaxYBound = 5;

            Assert.Equal("5 1 E", Rover.Instance.Run("3 3 E", "MMRMMRMRRM"));

        }

    }
}
