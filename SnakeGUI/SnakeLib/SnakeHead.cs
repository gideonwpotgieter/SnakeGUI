using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLib
{
    public class SnakeHead : SnakeBlock
    {
        public SnakeHead(V2<double> position, V2<double> direction) : base(position, direction)
        {
        }
    }
}
