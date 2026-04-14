using MarsRover.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Logic
{
    public interface IMovable
    {
        public abstract void MoveForward(Instruction instruction);
        public abstract void Rotate(Instruction instruction);
    }
}
