using SpaceLibrary.Concretes;
using SpaceLibrary.Enums;
using SpaceLibrary.Interfaces;
using System;

namespace SpaceLibrary.Objects
{
    public sealed class Rover: IMover, ISpacecraft
    {

        private IMover _mover;
        private ICompass _compass;
        private Position _currentPosition;
        private static readonly Lazy<Rover> lazy = new Lazy<Rover>(() =>  new Rover() );
        private object _locker = new object();
        private RunState _running = RunState.Stopped;

        public RunState Running
        {
            get
            {
                lock (_locker)
                {
                    return _running;
                }
            }
            set
            {
                lock (_locker)
                {
                    _running = value;
                }
            }
        }

        public static Rover Instance { get { return lazy.Value; } }

        private Rover()
        {
            Running = RunState.Running;

            _mover = new Mover();
            _compass = new Compass();
        }

        public string Run(string input1, string input2, string gridBounds, bool isBoundConsidered) //"1 2 N", "LMLMLMLMM" -> 1 3 N
        {
            string result = "";

            SetGridBounds(gridBounds, isBoundConsidered);

            while (Running == RunState.Running)
            {
                lock (_locker)
                {
                    _currentPosition = new Position().SetPosition(input1);

                    _currentPosition = Move(input2, _currentPosition, _compass, isBoundConsidered);

                    result = _currentPosition.X + " " + _currentPosition.Y + " " + _currentPosition.Direction.ToString();
                    return result;
                }
            }

            Dispose();

            return result;
        }

        private void SetGridBounds(string gridBounds, bool isBoundConsidered)
        {
            if(isBoundConsidered)
            {
                string[] bounds = gridBounds.Split(' ');
                Grid.MaxXBound = Convert.ToInt32(bounds[0]);
                Grid.MaxYBound = Convert.ToInt32(bounds[1]);
            }
        }

        public Position Move(string input2, Position position, ICompass compass, bool considerBoundarySwitch = false)
        {
            return _mover.Move(input2, position, compass, considerBoundarySwitch);
        }

        public void Dispose()
        {
            lock (_locker)
            {
                this.Dispose();
            }

            Running = RunState.Stopped;
        }
    }
}
