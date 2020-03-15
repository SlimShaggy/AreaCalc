using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AreaCalc
{
    public class Triangle : IFigureWithArea
    {
        public int Side1 => sidesByLength[0];
        public int Side2 => sidesByLength[1];
        public int Side3 => sidesByLength[2];

        public bool IsRight { get; }

        private readonly int[] sidesByLength;

        public Triangle(int side1, int side2, int side3)
        {
            const string greaterThanZeroMessage = "{0} must be greater than zero";

            if (side1 <= 0)
                throw new ArgumentException(string.Format(greaterThanZeroMessage, nameof(side1)), nameof(side1));

            if (side2 <= 0)
                throw new ArgumentException(string.Format(greaterThanZeroMessage, nameof(side2)), nameof(side2));

            if (side3 <= 0)
                throw new ArgumentException(string.Format(greaterThanZeroMessage, nameof(side3)), nameof(side3));

            if (side1 + side2 <= side3 || side2 + side3 <= side1 || side1 + side3 <= side2)
                throw new ArgumentException("Each side must be shorter than the sum of two others");

            sidesByLength = new[] {side1, side2, side3}.OrderBy(x => x).ToArray();
            IsRight = Side1 * Side1 + Side2 * Side2 == Side3 * Side3;
        }

        public double CalculateArea()
        {
            if (IsRight)
            {
                return Side1 * Side2 / 2.0;
            }

            var p = (Side1 + Side2 + Side3) / 2.0;
            return Math.Sqrt(p * (p - Side1) * (p - Side2) * (p - Side3));
        }
    }
}
