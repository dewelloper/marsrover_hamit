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
            Assert.Equal("1 3 N", new Rover(5, 5).Run("1 2 N", "LMLMLMLMM"));
        }

        [Fact]
        public void Test_Scenario_Row2()
        {
            //Assert.Equal("2 3 S", new Rover(5, 5).Run("3 3 E", "MRRMMRMRRM"));
            Assert.Equal("5 1 E", new Rover(5, 5).Run("3 3 E", "MMRMMRMRRM"));
            
        }
    }
}
