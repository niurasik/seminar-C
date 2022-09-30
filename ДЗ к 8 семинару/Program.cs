// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


// int[,] GenerateArray(int rows, int columns, int minRnd, int maxRnd)
// {
//     int[,] array = new int[rows, columns];
//     Random rnd = new Random();
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = rnd.Next(minRnd, maxRnd + 1);
//         }
//     }
//     return array;
// }
// void PrintArrayMatrix(int[,] matrix)
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

// int[,] SortArrayMaxMin(int[,] massiv)
// {
//     for (int i = 0; i < massiv.GetLength(0); i++)
//     {
//         for (int j = 0; j < massiv.GetLength(1)-1; j++)
//         {
//             int PozMaxChisla = j;
//             for (int k = j + 1; k < massiv.GetLength(1); k++)
//                 {
//                     if (massiv[i, k] > (massiv[i, PozMaxChisla]))
//                     {
//                         PozMaxChisla = k;
//                     }
//                 }
//                 int byfer = massiv[i, j];
//                 massiv[i, j] = massiv[i, PozMaxChisla];
//                 massiv[i, PozMaxChisla] = byfer;           
//         }
//     }
//     return massiv;
// }
// int[,] myarray = GenerateArray(rows: 3, columns: 4, minRnd: 0, maxRnd: 10);
// System.Console.WriteLine("Исходный массив: ");
// PrintArrayMatrix(myarray);
// System.Console.WriteLine("Массив, в котром упорядочены числа по убыванию элементы каждой строки: ");
// PrintArrayMatrix(SortArrayMaxMin(myarray));


// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и 
// выдаёт номер строки с наименьшей суммой элементов: 1 строка

// int[,] GenerateArray(int rows, int columns, int minRnd, int maxRnd)
// {
//     int[,] array = new int[rows, columns];
//     Random rnd = new Random();
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = rnd.Next(minRnd, maxRnd + 1);
//         }
//     }
//     return array;
// }
// void PrintArrayMatrix(int[,] matrix)
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
// int StringSmallestSumElement(int[,] array)
// {
//     int minSum = array[0, 0];
//     int StringMinSum = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         int sum = 0;
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             sum += array[i, j];
//         }
//         if (minSum > sum)
//         {
//             minSum = sum;
//             StringMinSum = i;
//         }
//     }
//       return StringMinSum + 1;
// }
// int[,] myarray = GenerateArray(rows: 3, columns: 4, minRnd: 0, maxRnd: 10);
// System.Console.WriteLine("Исходный массив: ");
// PrintArrayMatrix(myarray);
// System.Console.WriteLine($"Строка с наименьшей суммой элементов: " + $"{StringSmallestSumElement(myarray)}");


// Задача 58: Задайте две матрицы.
// Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// int[,] GenerateArray(int rows, int columns, int minRnd, int maxRnd)
// {
//     int[,] array = new int[rows, columns];
//     Random rnd = new Random();
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = rnd.Next(minRnd, maxRnd + 1);
//         }
//     }
//     return array;
// }
// void PrintArrayMatrix(int[,] matrix)
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
// int[,] MatrixMultiplication(int[,] matrix1, int[,] matrix2)
// {
//     int[,] matrix3 = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
//     for (int i = 0; i < matrix1.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix2.GetLength(1); j++)
//         {
//             for (int k = j + 1; k < matrix3.GetLength(1); k++)
//             {
//                 matrix3[i, j] += matrix1[i, k] * matrix2[j, k];
//             }
//         }
//     }
//     return matrix3;
// }
// int[,]array1 = GenerateArray(rows: 2, columns: 3, minRnd: 0, maxRnd: 5);
// System.Console.WriteLine("первая матрица: ");
// PrintArrayMatrix(array1);
// int[,]array2 = GenerateArray(rows: 3, columns: 3, minRnd: 0, maxRnd: 5);
// System.Console.WriteLine("вторая матрица: ");
// PrintArrayMatrix(array2);
// if(array1.GetLength(1) != array2.GetLength(0))
// {
//     System.Console.WriteLine($"Перемножить данные матрицы невозможно: " + $"число столбцов первой({array1.GetLength(1)}) не ровняется" + 
//     $"числу строк({array2.GetLength(0)})");
// }
// else
// {
//     System.Console.WriteLine("Результат - произведение двух матриц: ");
//     PrintArrayMatrix(MatrixMultiplication(array1, array2));
// }



// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// int[,,] GenerateArray3D()
// {
//     int[,,] array = new int[2, 2, 2];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 array[i, j, k] = (int)(Math.Pow(i + 1, 3) + Math.Pow(j + 2, 3) + Math.Pow(k + 3, 3));
//             }
//         }
//     }
//     return array;
// }
// void PrintArray3D(int[,,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 System.Console.Write($"{array[i, j, k], 3} ({i}, {j}, {k})");
//             }
//             System.Console.WriteLine();
//         }
//     }
// }
// PrintArray3D(GenerateArray3D());


// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// int Prompt(string message)
// {
//     System.Console.Write(message);
//     int result = Convert.ToInt32(Console.ReadLine());
//     return result;
// }

// int [,] CreateArray (int size){
//     int[,] matrix = new int[size, size];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = 0;
//         }
//     }
//     return matrix;
// }
// int[,] GetSpiralMatrix(int [,] matrix)
// {
//     int[,] spiralMatrix = matrix;
//     int size = matrix.GetLength(0);
//     for (int i = 0; i < spiralMatrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < spiralMatrix.GetLength(1); j++)
//         {
//             int num = 1;
//             for (int step = 0; step < size - 2; step++)
//             {
//                 for (int n = 0 + step; n < size - step; n++)
//                 {
//                     spiralMatrix[0 + step, n] = num;
//                     num++;
//                 }
//                 num--;
//                 for (int n = 0 + step; n < size - step; n++)
//                 {
//                     spiralMatrix[n, size - 1 - step] = num;
//                     num++;
//                 }
//                 num--;
//                 for (int n = size - 1 - step; n >= 0 + step; n--)
//                 {
//                     spiralMatrix[size - 1 - step, n] = num;
//                     num++;
//                 }
//                 num--;
//                 for (int n = size - 1 - step; n >= 1 + step; n--)
//                 {
//                     spiralMatrix[n, 0 + step] = num;
//                     num++;
//                 }
//             }
//         }
//     }
//     return spiralMatrix;
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

// int size = Prompt("Введите размер массива: ");
// int [,] matrix = CreateArray(size);
// int [,] spiralMatrix = GetSpiralMatrix(matrix);
// PrintArray (spiralMatrix);