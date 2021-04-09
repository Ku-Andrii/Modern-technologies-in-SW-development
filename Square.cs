using System;

namespace MTD_Laba_1
{
    public class Square : Figure
    {
        private readonly float _a;

        public Square()
        {
        }

        public Square(float a)
        {
            _a = a;
        }

        public override float Area()
        {
            return _a * _a;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine("Hello, I`m square");
        }
    }
}