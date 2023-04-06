using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_OOP
{
    internal class Cons
    {
        public int x, y;
        public Cons()
        {
            Console.WriteLine("asdfdsf");
        }
        public Cons(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public Cons(int x) : this()
        {

            this.x = x;
        }
    }
}
