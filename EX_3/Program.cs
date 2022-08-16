using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите кол-во чисел для вывода: ");
        int N = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= N; i++)
            Console.WriteLine(i + " => " + i * i * i);
    }


}