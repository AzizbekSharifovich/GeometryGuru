using System;

namespace GeometryGuru
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Uchburchakning a tomonini kiriting:");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Uchburchakning b tomonini kiriting:");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Uchburchakning c tomonini kiriting:");
            double c = Convert.ToDouble(Console.ReadLine());

            double p = (a + b + c) / 2.0;
            double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine($"Uchburchakning yuzi: {s}");
        }
    }
}
