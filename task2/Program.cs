using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите координаты первой точки:");
        Console.WriteLine("X:");
        int x1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Y:");
        int y1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Z:");
        int z1 = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Введите координаты второй точки:");
        Console.WriteLine("X:");
        int x2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Y:");
        int y2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Z:");
        int z2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(Math.Sqrt(Math.Pow(x1-x2,2)+Math.Pow(y1-y2,2)+Math.Pow(z1-z2,2)));

    }
}