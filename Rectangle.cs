namespace MTD_Laba_1
{
    public class Rectangle : Figure
    {
        private readonly ITemp _Temp;

        public Rectangle(ITemp Temp)
        {
            _Temp = Temp;
        }

        public int Perimeter(int a, int b)
        {
            var result = 2 * (a + b);
            _Temp.Temp(result);
            return result;
        }

        public int Area(int a, int b)
        {
            var result = a * b;
            _Temp.Temp(result);
            return result;
        }
    }
}