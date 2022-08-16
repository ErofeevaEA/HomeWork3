using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите число = ");
        int n = Convert.ToInt32(Console.ReadLine());

        if (n / 1000 == (n % 10) * 10 + (n % 100) / 10)
        {
            Console.WriteLine("Является палиндромом: Да ");
        }

        else
        {
            Console.WriteLine("Является палиндромом: Нет ");
        }
    }

}