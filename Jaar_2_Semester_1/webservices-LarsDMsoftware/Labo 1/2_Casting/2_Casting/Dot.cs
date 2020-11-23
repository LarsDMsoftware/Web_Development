using System;
using System.Collections.Generic;
using System.Text;

namespace _2_Casting
{
    class Dot
    {
        // Fields
        private int x { get; set; }
        private int y { get; set; }

        // Properties (altijd public)
        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public Dot(int x, int y)
        {
            this.Y = y;
            this.X = x;
        }

        public override string ToString()
        {
            return String.Format("Punt({0},{1})", x,y);
        }

    }
}
