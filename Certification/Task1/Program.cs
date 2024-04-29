// Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

using System;

class Program
{
    static void PrintRange(int m, int n)
    {
        if (m <= n)
        {
            Console.Write(m + " ");
            PrintRange(m + 1, n);
        }
       
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Введите значения M: ");
        int m = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите значения N: ");
        int n = int.Parse(Console.ReadLine());

        if (m <= n)
        {
        Console.WriteLine($"Натуральные числа в промежутке от {m} до {n}:");
        PrintRange(m, n);
        }
        else
        {
        Console.WriteLine ("M должно быть меньше или равно N.");
        }
    }
}