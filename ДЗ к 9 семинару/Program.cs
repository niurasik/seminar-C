﻿// Задача 64: Задайте значение N. Напишите программу,
//  которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// int Prompt(string message)
// {
//     System.Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

// void ShowNumbers(int number)
// {
//     if (number <= 0)
//     {
//         return;
//     }
//     System.Console.WriteLine(number);
//     ShowNumbers(number - 1);
// }
// int number = Prompt("Введите номер > ");
// ShowNumbers(number);


// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120

// int n, m, 
// s=0;
// Console.Write("Введи значение от: ");
// n = Convert.ToInt16(Console.ReadLine());
// Console.Write("Введи значение до: ");
// m = Convert.ToInt16(Console.ReadLine());
// for (int i = n; i <= m; i++)
//     s += i;
// Console.WriteLine(s);

// решение с применением функции
// Console.Write("Введи значение от: ");
// int n = Convert.ToInt16(Console.ReadLine());
// Console.Write("Введи значение до: ");
// int m = Convert.ToInt16(Console.ReadLine());

// int SumNumber(int m, int n)
// {
//     int sum = 0;
//     for (int i = n; i <= m; i++)
//     {
//         sum += i;
//     }
//     return sum;
// }
// System.Console.WriteLine($"Сумма натуральных элементов в промежутке = {SumNumber(m , n)}");

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
//  Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// int AkkermanFunc(int m, int n)
// {
//     if (m == 0)
//     {
//         return n + 1;
//     }
//     if (m > 0 && n == 0)
//     {
//         return AkkermanFunc(m - 1, 1);
//     }
//     return AkkermanFunc(m - 1, AkkermanFunc(m, n - 1));
// }

// Console.WriteLine(AkkermanFunc(2, 3));

