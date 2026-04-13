using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    public record PlateauSize(int x, int y)
    {
        public int Width = x;
        public int Length = y;
    }
}
