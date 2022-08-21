using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите пятизначное число:");
        string number1 = Console.ReadLine();
        if (number1[0] == number1[4])
        {
            if (number1[1] == number1[3])
            {
                Console.WriteLine(number1 + " - число палиндром.");
            }
            else
            {
                Console.WriteLine(number1 + " - не является палиндромом.");
            }
        }
        else
        {
            Console.WriteLine(number1 + " - не является палиндромом.");
        }

    }
}