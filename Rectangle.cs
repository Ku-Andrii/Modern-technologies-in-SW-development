namespace MTD_Laba_1
{
    public class Rectangle : Figure
    {
        private readonly float _a, _b;

        public Rectangle(float a, float b)
        {
            _a = a;
            _b = b;
        }

        public int Perimeter()
        {
            return (int)(2 * (_a + _b));
        }

        public override float Area()
        {
            return _a * _b;
        }
    }
}
