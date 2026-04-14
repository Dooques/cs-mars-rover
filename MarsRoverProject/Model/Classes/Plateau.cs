using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Model
{
    public class Plateau
    {
        public int[][] PlateauArray;
        public Plateau(int height, int width) 
        {
            if (height < 0 || width < 0)
            {
                throw new FormatException("Plateau size values must be positive");
            }
            if (height <= 1 || width <= 1) {
                throw new FormatException("Plateau must have space to move around.");
            }                
            
            PlateauArray = new int[height][];
            for (var i = 0; i < PlateauArray.Length; i++)
            {
                PlateauArray[i] = new int[width];
                for (var j = 0; j < height; j++) { PlateauArray[i][j] = j; }
            }
        }
    }
}
