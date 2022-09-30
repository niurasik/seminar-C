// Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// // m = 3, n = 4.

// int Prompt(string message)
// {
//     Console.Write(message);
//     int result = Convert.ToInt32(Console.ReadLine());
//     return result;
// }

// double[,] GenerateArray(int rows, int columns)
// {
//     double[,] array = new double[rows, columns];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().NextDouble() * 20 - 10; // для диапазона чисел от (-10, 10)
//         }
//     }
//     return array;
// }

// void PrintArray(double[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             System.Console.Write($"{matrix[i, j]:f1}\t");
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }

// int countRows = Prompt("Введите количество строк > ");
// int countColumns = Prompt("Введите количество столбцов > ");
// double[,] myArray = GenerateArray(countRows, countColumns);
// PrintArray(myArray);


// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// int Prompt(string message)
// {
//     System.Console.Write(message);
//     int result = Convert.ToInt32(Console.ReadLine());
//     return result;
// }

// int[,] GenerateArray(int rows, int colums)
// {
//     int[,] array = new int[rows, colums];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(-10, 11);
//         }
//     }
//     return array;
// }

// void PrintArray(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             System.Console.Write($"{matrix[i, j]}\t");
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }

// bool FindPositinOnArray(int [,]array, int row, int column)
// {
//     int searchRow = row-1;
//     int searchColumns = column-1;
//     bool position = false;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (i == searchRow && j == searchColumns)
//             {
//                 position = true;
//             }
//         }
//     }
//     return position;
// }

// int rowsOnArray = Prompt("Введите количество строк > ");
// int columnsOnArray = Prompt("Введите количество столбцов > ");
// int[,] NewArray = GenerateArray(rowsOnArray, columnsOnArray);
// PrintArray(NewArray);

// int searchyRow = Prompt("Введите номер строки того числа, которое нужно найти в массиве: ");
// int searchyColumn = Prompt("Введите номер стобца того числа, которое нужно найти в массиве: ");
// if (FindPositinOnArray(NewArray, searchyRow, searchyColumn))
// {
//     Console.WriteLine($"Значение элемента {searchyRow} строки и {searchyColumn} столбца > {NewArray[searchyRow-1,searchyColumn-1]}");
// }
// else
// {
//     Console.WriteLine("Числа нет в массиве");
// }


// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

int Prompt(string message)
{
    System.Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[,] GenerateArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 11);
        }
    }
    return array;
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]}\t");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

void FindMeanOnColumnsArray(int[,] matrix)
{
    double arithmeticMean = 0;
    double sumColumns = 0;

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sumColumns += matrix[i, j];
        }
        arithmeticMean = sumColumns / matrix.GetLength(0);
        Console.WriteLine($" Среднее арифметическое столбца {j + 1} = {arithmeticMean:F2}");
        sumColumns = 0;
    }
}

int rowsOnArray = Prompt("Введите количество строк > ");
int columnsOnArray = Prompt("Введите количество столбцов > ");
int[,] myArray = GenerateArray(rowsOnArray, columnsOnArray);
PrintArray(myArray);
FindMeanOnColumnsArray(myArray);

