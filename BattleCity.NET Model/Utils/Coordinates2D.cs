using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BattleCityDotNETModel.Utils
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

        public static bool operator==(Coordinates2D first, Coordinates2D second)
        {
            return first.X == second.X && first.Y == second.Y;
        }

        public static bool operator !=(Coordinates2D first, Coordinates2D second)
        {
            return !(first == second);
        }

        public bool Equals(Coordinates2D other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other.X == X && other.Y == Y;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof (Coordinates2D)) return false;
            return Equals((Coordinates2D) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (X*397) ^ Y;
            }
        }
    }    
}
