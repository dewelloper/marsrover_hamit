using SpaceLibrary.Enums;
using SpaceLibrary.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceLibrary.Interfaces
{
    public interface IMover
    {
        Position Move(string input2, Position position, ICompass compass, bool boundarySwitch = false);
    }
}
