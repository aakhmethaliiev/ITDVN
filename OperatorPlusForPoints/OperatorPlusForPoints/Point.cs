namespace OperatorPlusForPoints
{
    /// <summary> Class which provide  </summary>
    public class Point
    {
        /// <summary> X coordinate. </summary>
        private int _x;

        /// <summary> Y coordinate. </summary>
        private readonly int _y;

        /// <summary> Z coordinate. </summary>
        private readonly int _z;

        public Point(int x, int y, int z)
        {
            _x = x;
            _y = y;
            _z = z;
        }

        /// <summary> Overload operator +. </summary>
        /// <param name="p1"> Point 1. </param>
        /// <param name="p2"> Point 2. </param>
        /// <returns> Point which contains sum of each coordinates. </returns>
        public static Point operator +(Point p1, Point p2)
        {
            return new Point(p1._x + p2._x, p1._y + p2._y, p1._z + p2._z);
        }

        /// <summary> Override method ToString(). </summary>
        /// <returns> Coordinates in string format. </returns>
        public override string ToString()
        {
            return string.Format($"[{_x}, {_y}, {_z}]");
        }
    }
}