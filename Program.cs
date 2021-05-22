using System;

namespace lr
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, c = 0;
            int[] v = new int[100001];
            int[] mic = new int[100001];
            int[] mare = new int[100001];
            n = int.Parse(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
            int maxim = v[0];
            for (i = 1; i < n - 1; i++)
                if (v[i] > maxim)
                {
                    maxim = v[i];
                    mic[i] = 1;
                }
            int minim = v[n-1];
            for (i = n - 2; i > 2; i--)
                if (v[i] < minim)
                {
                    minim = v[i];
                    mare[i] = 1;
                }
            for (i = 1; i < n - 1; i++)
                if (mic[i] == 1 && mare[i] == 1)
                    c++;
            Console.WriteLine(c);

        }
    }
}
