using SpaceLibrary.Enums;
using SpaceLibrary.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceLibrary.Interfaces
{
    public interface ICompass
    {
        Direction Navigate(Direction direction, char directionCharacter);
    }
}
