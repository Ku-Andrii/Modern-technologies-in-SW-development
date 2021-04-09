using System;

namespace MTD_Laba_1
{
    public class Circle : Figure
    {
        private readonly float _radius;

        public Circle(float radius)
        {
            _radius = radius;
        }

        public override float Area()
        {
            return (float)(Math.PI * _radius * _radius);
        }
    }
}