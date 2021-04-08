using System;

namespace MTD_Laba_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Rhombus rhom = new Rhombus();
            var result = rhom.Perimeter(5);
            Console.WriteLine(result);*/
            Figure op = new Square();
            op.Show();
            Console.ReadKey();
        }
    }

    public class Figure
    {
        public virtual void Show()
        {
            Console.WriteLine("Hi, I`m figure");
        }
    }

    class Square : Figure
    {
        public override void Show()
        {
            base.Show();
            Console.WriteLine("Hello, I`m square");
        }
    }
}