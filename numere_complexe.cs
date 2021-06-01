using System;
namespace numere_complexe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Introduceti coordonatele primului numar complex:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            complex1(a, b);
            Console.WriteLine();
            Console.WriteLine("Introduceti coordonatele celui de-al doilea numar complex:");
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            complex2(c, d);
            sumadif(a, b, c, d);
            Console.WriteLine(" ");
            FormGeo(a, b, 1);
            Console.WriteLine(" ");
            Console.WriteLine("Introduceti puterea lui n: ");
            int n = int.Parse(Console.ReadLine());
            FormGeo(a, b, n);
        }

        static void complex1(int a, int b)
        {
            Console.WriteLine("x= " + a + " + i*" + b);
        }
        static void complex2(int c, int d)
        {
            Console.WriteLine("y= " + c + " + i*" + d);
        }
        static void sumadif(int a, int b, int c, int d)
        {
            Console.WriteLine("x+y = " + (a + c) + " + i*" + (b + d));
            Console.WriteLine(" ");
            Console.WriteLine("x-y = " + (a - c) + " - i*" + (b - d));
            Console.WriteLine(" ");
            Console.WriteLine("x*y = " + (a * c - b * d) + " + i*" + (a * d + b * c));
            Console.WriteLine(" ");
        }
        static void FormGeo(int a, int b, int n)
        {
            double r = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            double teta = Math.Atan(b / a);
            Console.WriteLine("Forma geometrica :  x = " + r + "(cos" + teta + "+ i*sin" + teta);
            Console.WriteLine(" ");
            double s = Math.Sin(teta);
            double c = Math.Cos(teta);
            Console.WriteLine($"Dupa rezolvare, forma geometrica a lui x este x = {r * c} + i*{r * s}");
            Console.WriteLine(" ");
            double s2 = Math.Sin(n * teta);
            double c2 = Math.Cos(n * teta);
            Console.WriteLine($"x^{n}= {r * c2} + i*{r * s2}");
        }
    }

}
