using SpaceLibrary.Concretes;
using SpaceLibrary.Enums;
using SpaceLibrary.Interfaces;
using System;

namespace SpaceLibrary.Objects
{
    public class Rover: IMover
    {

        IMover _mover;
        ICompass _compass;
        Position _currentPosition;

        public Rover(ICompass compass, IMover mover)
        {
            _mover = mover;
            _compass = compass;
        }

        public Rover(int maxX, int maxY)
        {
            _mover = new Mover();
            _compass = new Compass();
            Grid.MaxXBound = maxX;
            Grid.MaxYBound = maxY;
        }

        public string Run(string input1, string input2) //"1 2 N", "LMLMLMLMM" -> 1 3 N
        {
            _currentPosition = new Position().SetPosition(input1);

            _currentPosition = Move(input2, _currentPosition, _compass);

            return _currentPosition.X + " " + _currentPosition.Y + " " + _currentPosition.Direction.ToString();
        }

        public Position Move(string input2, Position position, ICompass compass, bool considerBoundarySwitch = false)
        {
            return _mover.Move(input2, position, compass, considerBoundarySwitch);
        }

    }
}
