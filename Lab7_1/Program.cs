using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"Два треугольника заданы длинами своих сторон.
Определить, площадь какого из них больше (создать метод для вычисления  площади  треугольника по длинам его сторон).  
Для решения задачи можно использовать формулу Герона");
            Console.WriteLine("");

            
            double[] Triangle1 = new double[3];
            double[] Triangle2 = new double[3];

            for (int i = 0; i <= 2; i++)
            {
                Console.Write($"Введите сторону {i + 1} треугольника 1: ");
                Triangle1[i] = double.Parse(Console.ReadLine());
            }

            for (int i = 0; i <= 2; i++)
            {
                Console.Write($"Введите сторону {i + 1} треугольника 2: ");
                Triangle2[i] = double.Parse(Console.ReadLine());
            }
                        
            double S1 = GetTriangleArea(Triangle1);
            double S2 = GetTriangleArea(Triangle2);
                        
            if (S1 == S2)
            {

                Console.Write($"Площади треугольниокв равны!");
                Console.ReadKey();
                return; 
            }

            if (GetTriangleArea(Triangle1) > GetTriangleArea(Triangle2))
            {
                Console.Write($"Площадь первого треугольника ({S1}) больше чем второго ({S2})");
            }
            else
            {
                Console.Write($"Площадь первого треугольника ({S1}) меньше чем второго ({S2})");
            }

            Console.ReadKey();
        }

        
        static double GetCubeVolume(double Side) => Math.Pow(Side, 3);

       
        static double GetCubeSurfaceArea(double Side) => 6 * Math.Pow(Side, 2);

                
        static void GetCubeVolumeAndSurfacArea(double Side, out double SurfaceArea, out double Volume)
        {
            SurfaceArea = GetCubeSurfaceArea(Side);
            Volume = GetCubeVolume(Side);
        }
    }
}
