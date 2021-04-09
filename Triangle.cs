namespace MTD_Laba_1
{
    public abstract class Triangle : Figure
    {
        private readonly float _a, _b, _c, _h;

        public Triangle(float a, float b, float c, float h)
        {
            _a = a;
            _b = b;
            _c = c;
            _h = h;
        }

        public override float Area()
        {
            return 1 / 2 * _a * _h;
        }

        public abstract float Perimeter();
    }
}