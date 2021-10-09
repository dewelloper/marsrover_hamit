using SpaceLibrary.Concretes;
using SpaceLibrary.Enums;
using SpaceLibrary.Interfaces;
using System;

namespace SpaceLibrary.Objects
{
    public sealed class Rover: IMover
    {

        private IMover _mover;
        private ICompass _compass;
        private Position _currentPosition;
        private static readonly Lazy<Rover> lazy = new Lazy<Rover>(() =>  new Rover() );

        public static Rover Instance { get { return lazy.Value; } }

        private Rover()
        {
            _mover = new Mover();
            _compass = new Compass();
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
