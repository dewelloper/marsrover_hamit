using SpaceLibrary.Enums;
using SpaceLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceLibrary.Concretes
{

    public class Compass: ICompass
    {

        public Direction Navigate(Direction direction, char directionCharacter)
        {
            if (directionCharacter == 'R' && direction == Direction.W)
                return Direction.N;

            if (directionCharacter == 'L' && direction == Direction.N)
                return Direction.W;

            if (directionCharacter == 'L')
            {
                return (Direction)((int)direction) - 1;
            }
            else if (directionCharacter == 'R')
            {
                return (Direction)((int)direction) + 1;
            }

            return direction;
        }

    }
}
