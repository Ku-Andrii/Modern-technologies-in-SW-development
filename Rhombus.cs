namespace MTD_Laba_1
{
    public class Rhombus : Figure
    {
        private readonly float _a, _h;

        public Rhombus(float a, float h)
        {
            _a = a;
            _h = h;
        }

        public int Perimeter()
        {
            return (int)(4 * _a);
        }

        public override float Area()
        {
            return _a * _h;
        }
    }
}
