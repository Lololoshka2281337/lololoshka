using System;
using System.Collections.Generic;
using System.Text;

namespace ekz
{
    class Class1
    {
        public void ekz()
        {
            double a, b, c, p, s;
            s = 0;
            Console.WriteLine("Введите А");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите B");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите C");
            c = Convert.ToDouble(Console.ReadLine());
            p =(a+b+c)/2;
            if (p >= 0)
                s = Math.Sqrt(p - a) * (p - b);
            Console.WriteLine("Площадь треугольника по формуле Герона равна: {0}", s);
        }
        
    }
}
