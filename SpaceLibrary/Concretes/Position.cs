using SpaceLibrary.Enums;
using SpaceLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceLibrary.Concretes
{

    public class Position: IPosition
    {

        public int X { get; set; }
        public int Y { get; set; }

        public Direction Direction { get; set; }

        public Position() { }

        public Position(int x, int y, Direction direction)
        {
            X = x;
            Y = y;
            Direction = direction;
        }

        public Position SetPosition(string input1)
        {
            string[] input1Splited = input1.Split(" ");

            Direction = (Direction)Enum.Parse(typeof(Direction), input1Splited[2]);
            X = Convert.ToInt32(input1Splited[0]);
            Y = Convert.ToInt32(input1Splited[1]);

            return this; 
        }

    }
}
