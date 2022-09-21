// // Задача 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// // 0, 7, 8, -2, -2 -> 2
// // -1, -7, 567, 89, 223-> 3

// Console.WriteLine("Введите числа:");
// string numbers = Console.ReadLine();
// // нам нужно перебрать каждый элемент строки, если это не запятая или пробел, 
// // кладем его в массив, если запятая или пробел, делаем ++
// string[] newNumbers = new string[numbers.Length];
// int k = 0;
// for (int i = 0; i < newNumbers.Length; i++)
// {
//     if (numbers[i] == ',')
//     {
//         k++;
//     }
//     else
//     {
//         newNumbers[k] = newNumbers[k] + $"{numbers[i]}";
//     }
// }
// k++;
// int[] resultNumbers = new int[k];
// PrintArray(resultNumbers, newNumbers);
// int sum = 0;
// for (int i = 0; i < k; i++)
// {
//     if (resultNumbers[i] > 0)
//     {
//         sum++;
//     }
// }
// Console.WriteLine("Количество чисел больше 0: " + sum);

// void PrintArray(int[] array, string[] string1)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = Convert.ToInt32(string1[i]);
//         Console.Write(array[i] + "  ");
//     }
//     Console.WriteLine();
// }

// Задача 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// // -1, -7, 567, 89, 223-> 3

// Console.Clear();

// Console.WriteLine($"Задача 41. Cколько чисел больше 0 ввёл пользователь \n");
// Console.Write($"Введи число М(количество чисел): ");
// int m = Convert.ToInt32(Console.ReadLine());
// int[] massiveNumbers = new int[m];

// void InputNumbers(int m){
// for (int i = 0; i < m; i++)
//   {
//     Console.Write($"Введи {i+1} число: ");
//     massiveNumbers[i] = Convert.ToInt32(Console.ReadLine());
//   }
// }


// int Comparison(int[] massiveNumbers)
// {
//   int count = 0;
//   for (int i = 0; i < massiveNumbers.Length; i++)
//   {
//     if(massiveNumbers[i] > 0 ) count += 1; 
//   }
//   return count;
// }

// InputNumbers(m);

// Console.WriteLine($"Введено чисел больше 0: {Comparison(massiveNumbers)} ");


// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// const int X_COORD = 0;
// const int Y_COORD = 1;
// const int K_DATA = 0;
// const int B_DATA = 1;

// int[] GetCrossPoint(int[] dataLine1, int[] dataLine2)
// {
//     int[] point = new int[2];
//     point[X_COORD] = (dataLine1[B_DATA] - dataLine2[B_DATA]) / (dataLine2[K_DATA] - dataLine1[K_DATA]);
//     point[Y_COORD] = (dataLine2[K_DATA] * dataLine1[B_DATA] - dataLine1[K_DATA] * dataLine2[B_DATA]) / (dataLine2[K_DATA] - dataLine1[K_DATA]);
//     return point;
// }

// bool Validate(int k1, int k2)
// {
//     if (k1 == k2)
//     {
//         Console.Write("Заданные прямые не пересекаются");
//         return false;
//     }
//     return true;
// }
// int[] InputDataLine(int number)
// {
//     int[] dataLine = new int[2];
//     Console.WriteLine($"Введите b{number}: ");
//     dataLine[B_DATA] = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine($"Введите k{number}: ");
//     dataLine[K_DATA] = Convert.ToInt32(Console.ReadLine());
//     return dataLine;
// }

// int[] lineData1 = InputDataLine(1);
// int[] lineData2 = InputDataLine(2);

// if (Validate(lineData1[K_DATA], lineData2[K_DATA]))
// {
//     int[] crossPoint = GetCrossPoint(lineData1, lineData2);
//     Console.Write($"Точка пересечения прямых: ({crossPoint[X_COORD]}; {crossPoint[Y_COORD]})");
// }
