using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите число:");
        int n = Convert.ToInt32(Console.ReadLine());
        int count = 1;
        while (count <= n)
        {
            Console.Write(count + " ");
            Console.WriteLine(Math.Pow(count,3));
            count++;
        }
    }
}