using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLib
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Snake(new SnakeHead(new V2<double>(100, 100), new V2<double>(1, 0)));
            s.AddTail();
            s.AddTail();
            s.AddTail();
            s.AddTail();

            s.Update();
            s.TurnLeft();
            s.Update();
            s.TurnRight();
            s.Update();

            Console.Read();
        }
    }
}
