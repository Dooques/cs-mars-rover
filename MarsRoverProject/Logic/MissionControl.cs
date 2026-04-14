using MarsRover.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Logic
{
    public class MissionControl
    {
        public static Dictionary<String, Rover> DeployedRovers;

        public MissionControl()
        {
            DeployedRovers = new Dictionary<String, Rover>();
        }

        public void DeployRover(Position startingPosition, Plateau plateau) 
        {

        }
    }
}
