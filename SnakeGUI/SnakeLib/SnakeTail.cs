using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLib
{
    public class SnakeTail : SnakeBlock
    {
        public SnakeBlock SnakeParent { get; private set; }

        public SnakeTail(SnakeBlock snakeParent, V2<double> position, V2<double> direction) : base(position, direction)
        {
        }
    }
}
