using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BattleCityDotNET_Model.Utils
{
    public class Coordinates2D
    {
        public Coordinates2D(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; private set; }
        public int Y { get; private set; }

        public Coordinates2D DecrementX()
        {
            return new Coordinates2D(this.X - 1, this.Y);
        }

        public Coordinates2D DecrementY()
        {
            return new Coordinates2D(this.X, this.Y - 1);
        }

        public Coordinates2D IncrementX()
        {
            return new Coordinates2D(this.X + 1, this.Y);
        }

        public Coordinates2D IncrementY()
        {
            return new Coordinates2D(this.X, this.Y + 1);
        }
    }    
}
