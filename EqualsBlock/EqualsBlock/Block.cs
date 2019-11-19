using System;

namespace EqualsBlock
{
    /// <summary> Class which provide block with 4 sides. </summary>
    public class Block
    {
        /// <summary> Side a. </summary>
        private readonly int _a;

        /// <summary> Side b. </summary>
        private readonly int _b;

        /// <summary> Side c. </summary>
        private readonly int _c;

        /// <summary> Side d. </summary>
        private readonly int _d;

        /// <summary> Constructor with parameters. </summary>
        /// <param name="a"> Value of side a. </param>
        /// <param name="b"> Value of side b. </param>
        /// <param name="c"> Value of side c. </param>
        /// <param name="d"> Value of side d. </param>
        public Block(int a, int b, int c, int d)
        {
            _a = a;
            _b = b;
            _c = c;
            _d = d;
        }

        /// <summary> Override equals for compare blocs. </summary>
        /// <returns> Result of compare. </returns>
        public override bool Equals(object o)
        {
            if (!(o is Block block)) return false;
            return block._a == _a && 
                   block._b == _b && 
                   block._c == _c && 
                   block._d == _d;
        }

        /// <summary> Override GetHashCode. </summary>
        /// <returns> Mult all sides. </returns>
        public override int GetHashCode()
        {
            return _a*_b + _c*_d;
        }

        /// <summary>
        /// Override ToString for get info about block.
        /// </summary>
        /// <returns> Info about block. </returns>
        public override string ToString()
        {
            return string.Format($"Block sides: {_a}, {_b}, {_c}, {_d}");
        }
    }
}