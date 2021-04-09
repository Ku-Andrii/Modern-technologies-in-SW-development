namespace MTD_Laba_1
{
    public class Parallelogram : Figure
    {
        private readonly float _a, _b, _h;

        public Parallelogram(float a, float b, float h)
        {
            _a = a;
            _b = b;
            _h = h;
        }

        public int Perimeter()
        {
            return (int)(2 * (_a + _b));
        }

        public override float Area()
        {
            return _a * _h;
        }
    }
}
