using System;

namespace MTD_Laba_1
{
    public abstract class Figure
    {
        public virtual void Show()
        {
            Console.WriteLine("Hi, I`m figure");
        }

        public abstract float Area();
    }
}