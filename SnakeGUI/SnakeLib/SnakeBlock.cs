using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLib
{
    public class SnakeBlock
    {
        public V2<double> Position { get; set; }
        public V2<double> Direction { get; set; }

        public SnakeBlock(V2<double> position, V2<double> direction)
        {
            Position = position;
            Direction = direction;
        }
    }
}
