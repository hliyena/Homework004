// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. 


// Console.WriteLine("введите число A");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите число B");
// int b = Convert.ToInt32(Console.ReadLine());
// int A = a;

// for (int i = 1; i < b; i++)
// {
// A = A * a;
// }
// Console.WriteLine($"{a} в степени {b} равно: " + A);



// // Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.


// Console.Write("Введите любое число: ");
// int numberA = Convert.ToInt32(Console.ReadLine());

//   int Sum(int numberA)
//   {    
//     int counter = Convert.ToString(numberA).Length;
//     int rat = 0;
//     int result = 0;

//     for (int i = 0; i < counter; i++)
//     {
//       rat = numberA - numberA % 10;
//       result = result + (numberA - rat);
//       numberA = numberA / 10;
//     }
//    return result;
//   }

// int sum = Sum(numberA);
// Console.WriteLine("Сумма цифр в введенном числе: " + sum);



// // Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// // (числа берете любые)


// int[] array = Array(8);
// Console.WriteLine($"[{String.Join(", ", array)}]");

// int[] Array(int size)
// {
//     int[] result = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         result[i] = new Random().Next(0, 10);
//     }
//     return result;
// }