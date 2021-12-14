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
        begin:
            Console.Write("Введите номер задачи (1-2):");

            string Selected = Console.ReadLine();

            switch (Selected)
            {
                case "1":
                    Exercice1();
                    break;
                case "2":
                    Exercice2();
                    break;

                default:
                    Console.WriteLine("Введен неверный номер упражнения, попрбуйте еще раз.");
                    goto begin;
            }
        }


        
        static double GetTriangleArea(double S1, double S2, double S3)
        {
            return Math.Sqrt(((S1 + S2 + S3) / 2) * (((S1 + S2 + S3) / 2) - S1) * (((S1 + S2 + S3) / 2) - S2) * (((S1 + S2 + S3) / 2) - S3));
        }

        
        static double GetTriangleArea(double[] ar)
        => Math.Sqrt(((ar[0] + ar[1] + ar[2]) / 2) * (((ar[0] + ar[1] + ar[2]) / 2) - ar[0]) * (((ar[0] + ar[1] + ar[2]) / 2) - ar[1]) * (((ar[0] + ar[1] + ar[2]) / 2) - ar[2]));
        



        static void Exercice1()
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

            //Считаем площади обоих треуголников
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

        static void Exercice2()
        {
            
            Console.WriteLine(@"Создать метод для вычисления объема и площади поверхности куба по длине его ребра.");
            Console.WriteLine("");
            Console.Write("Введите ребро куба:");
            double Side = double.Parse(Console.ReadLine());

            
            GetCubeVolumeAndSurfacArea(Side, out double SurfaceArea, out double Volume);

            Console.WriteLine($"Объём куба:{Volume} , площадь поверхности: {SurfaceArea}");

            Console.ReadKey();
        }
    }
}
