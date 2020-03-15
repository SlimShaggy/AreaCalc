using System;

namespace AreaCalc
{
    public class Circle : IFigureWithArea
    {
        public int Radius { get; }

        public Circle(int radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Radius must be greater than zero", nameof(radius));

            Radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
