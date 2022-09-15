// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// Console.Write("Введите число N: ");
// int numberN = Convert.ToInt32(Console.ReadLine());

//   int SumNumber(int numberN){
    
//     int counter = Convert.ToString(numberN).Length;
//     int advance = 0;
//     int result = 0;

//     for (int i = 0; i < counter; i++){
//       advance = numberN - numberN % 10;
//       result = result + (numberN - advance);
//       numberN = numberN / 10;
//     }
//    return result;
//   }

// int sumNumber = SumNumber(numberN);
// Console.WriteLine("Сумма цифр в числе: " + sumNumber);


// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

// Console.Write("Введите число A: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число B: ");
// int b = Convert.ToInt32(Console.ReadLine());

// double DegreeOfNumber (int a, int b)
// {
//         double degree = 1;
//         for (int i = 1; i <= b; i++){
//             degree *= a;
//         } 
//            return degree;
// }

// System.Console.WriteLine($"{a} в степени {b} = {DegreeOfNumber (a , b)}");



// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// int[] GetArray()
// {
//     int[] result = new int[8];

//     for (int i = 0; i < result.Length; i++)
//     {
//         result[i] = new Random().Next(100);
//     }

//     return result;
// }

// void PrintArray(int[] arr)
// {
//     int i = 0;
//     Console.Write("[");
//     while (i < arr.Length)
//     {
//         Console.Write(arr[i]);
//         i++;
//         if (i < arr.Length)
//         {
//             Console.Write(", ");
//         }
//     }
//     Console.Write("]");
// }

// PrintArray(GetArray());
