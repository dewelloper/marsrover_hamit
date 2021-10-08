using SpaceLibrary.Enums;
using SpaceLibrary.Interfaces;
using SpaceLibrary.Concretes;
using SpaceLibrary.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceLibrary.Concretes
{
    class Mover : IMover
    {

        public Position Move(string input2, Position position, ICompass compass, bool boundarySwitch = false)
        {
            Direction direction = position.Direction;
            char[] commands = input2.ToCharArray();
            for (int h = 0; h < input2.Length; h++)
            {
                if (commands[h] != 'M')
                {
                    direction = compass.Navigate(direction, commands[h]);
                    position.Direction = direction;
                    continue;
                }

                ConsiderGridBoundary(direction, position, boundarySwitch);

                if (direction == Direction.E)
                    position.X++;
                if (direction == Direction.W)
                    position.X--;
                if (direction == Direction.N)
                    position.Y++;
                if (direction == Direction.S)
                    position.Y--;
            }

            return position;
        }

        private void ConsiderGridBoundary(Direction direction, Position position, bool boundarySwitch)
        {
            if (boundarySwitch == false)
                return;

            if ((direction == Direction.E || direction == Direction.W) && position.X == Grid.MaxXBound)
            {
                throw new ArgumentException("MaxXException!");
            }
            if ((direction == Direction.N || direction == Direction.S) && position.X == Grid.MaxYBound)
            {
                throw new ArgumentException("MaxYException!");
            }
        }
    }
}
