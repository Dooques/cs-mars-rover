using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Input_Layer
{
    internal record PlataeuSize(int x, int y)
    {
        int Width = x;
        int Height = y;
    }
}
