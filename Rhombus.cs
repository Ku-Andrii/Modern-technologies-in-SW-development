namespace MTD_Laba_1
{
    public class Rhombus : Figure
    {
        private readonly ITemp _Temp;

        public Rhombus(ITemp Temp)
        {
            _Temp = Temp;
        }

        public int Perimeter(int a)
        {
            var result = 4 * a;
            _Temp.Temp(result);
            return result;
        }

        public int Area(int a, int h)
        {
            var result = a * h;
            _Temp.Temp(result);
            return result;
        }
    }
}