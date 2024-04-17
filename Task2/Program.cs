using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите ребро куба:\nR=");
            double edge = Convert.ToDouble(Console.ReadLine());
            double surfaceArea = 0;
            double volume = 0;
            VolumeAndArea(edge,out surfaceArea,out volume);
            Console.WriteLine($"Площадь поверхности куба = {surfaceArea}\n" +
                $"Объеме куба = {volume}");
            Console.ReadKey();
        }
        static void VolumeAndArea(double edge, out double surfaceArea, out double volume)
        {
            surfaceArea = 6 * edge * edge;
            volume = Math.Pow(edge, 3);
        }
    }
}
