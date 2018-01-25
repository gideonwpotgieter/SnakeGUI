using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLib
{
    public enum SnakeDirection
    {
        Left,
        Right,
        Straight
    }

    public class Snake
    {
        public SnakeHead Head { get; private set; }
        public List<SnakeTail> Tail { get; private set; }
        public SnakeDirection Direction { get; private set; }

        public Snake(SnakeHead head)
        {
            Head = head;
            Tail = new List<SnakeTail>();
            Direction = SnakeDirection.Straight;
        }

        public SnakeTail _GetTailFromBlock(SnakeBlock sb)
        {
            var x = sb.Position.X - sb.Direction.X * 10;
            var y = sb.Position.Y - sb.Direction.Y * 10;

            return new SnakeTail(sb, new V2<double>(x, y), new V2<double>(sb.Direction.X, sb.Direction.Y));
        }

        public void AddTail()
        {
            if (Tail.Count == 0)
                Tail.Add(_GetTailFromBlock(Head));
            else
                Tail.Add(_GetTailFromBlock(Tail.Last()));
        }

        V2<double> _UpdateDirection(V2<double> direction, SnakeDirection dir)
        {
            switch(dir)
            {
                default:
                case SnakeDirection.Straight:
                    break;
                case SnakeDirection.Left:
                    if (direction.X == 1 && direction.Y == 0)
                        return new V2<double>(0, -1);
                    else if (direction.X == 0 && direction.Y == -1)
                        return new V2<double>(-1, 0);
                    else if (direction.X == -1 && direction.Y == 0)
                        return new V2<double>(0, 1);
                    else if (direction.X == 0 && direction.Y == 1)
                        return new V2<double>(1, 0);
                    else
                        break;
                case SnakeDirection.Right:
                    if (direction.X == 1 && direction.Y == 0)
                        return new V2<double>(0, 1);
                    else if (direction.X == 0 && direction.Y == -1)
                        return new V2<double>(1, 0);
                    else if (direction.X == -1 && direction.Y == 0)
                        return new V2<double>(0, -1);
                    else if (direction.X == 0 && direction.Y == 1)
                        return new V2<double>(-1, 0);
                    else
                        break;
            }

            return direction;
        }

        public void TurnLeft()
        {
            Direction = SnakeDirection.Left;
        }

        public void TurnRight()
        {
            Direction = SnakeDirection.Right;
        }

        public void Update()
        {
            Head.Direction = _UpdateDirection(Head.Direction, Direction);
            Direction = SnakeDirection.Straight;

            foreach(var block in Tail)
            {
                block.Position.X = block.SnakeParent.Position.X;
                block.Position.Y = block.SnakeParent.Position.Y;
            }

            Head.Position.X += Head.Direction.X * 10;
            Head.Position.Y += Head.Direction.Y * 10;
        }
    }
}
