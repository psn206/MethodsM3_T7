using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1 = 0, x2 = 0, x3 = 0, y1 = 0, y2 = 0, y3 = 0;
            string nameT1 = "первого";
            string nameT2 = "второго";  
            EnteringSide(ref x1, ref x2, ref x3, nameT1);
            EnteringSide(ref y1, ref y2, ref y3, nameT2);

            double area1 = AreaTriangle(x1, x2, x3);
            double area2 = AreaTriangle(y1, y2, y3);

            if (area1 > area2)
            {
                Console.WriteLine($"Площадь {nameT1} треугольника ({area1:f2}) больше {nameT2} ({area2:f2})");
            }
            else if (area1 < area2)
            {
                Console.WriteLine($"Площадь {nameT2} треугольника ({area1:f2}) больше {nameT1} ({area2:f2})");
            }
            else
            {
                Console.WriteLine($"Площади треугольников равны ({area1:f2}) ");
            }
            Console.ReadKey();
        }
        static void EnteringSide(ref double firstSide, ref double secondSide, ref double thirdSide, string nameTriangle)
        {
            Console.WriteLine($"Введите стороны {nameTriangle} треугольника");
            Console.Write("Сторона А = ");
            firstSide = Convert.ToDouble(Console.ReadLine());
            Console.Write("Сторона B = ");
            secondSide = Convert.ToDouble(Console.ReadLine());
            Console.Write("Сторона C = ");
            thirdSide = Convert.ToDouble(Console.ReadLine());

        }
        static double AreaTriangle(double firstSide, double secondSide, double thirdSide)
        {
            double halfPerimeter = (firstSide + secondSide + thirdSide) / 2.0;
            double s = Math.Sqrt(halfPerimeter * (halfPerimeter - firstSide) *
                 (halfPerimeter - secondSide) * (halfPerimeter - thirdSide));
            Console.WriteLine(s);
            return s;
        }
    }
}
