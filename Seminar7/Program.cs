﻿// Задача 48.

// Console.WriteLine("Введите размерность m");
// bool isNumber1 = int.TryParse(Console.ReadLine(), out int m);

// Console.WriteLine("Введите размерность n");
// bool isNumber2 = int.TryParse(Console.ReadLine(), out int n);

// if (!isNumber1 || n <= 0 || m <= 0 || !isNumber2)
// {
//     Console.WriteLine("Invalid number");
//     return;
// }

// int[,] result = CreateRandomArray(m, n);
// Print2DArray(result);

// void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] CreateRandomArray(int m, int n)
// {
//     int[,] array = new int[m, n];

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j] = i + j;
//         }
//     }
//     return array;
// }


// Задача 49. Задать двумерный массив. Найти элементы у которых оба индекса четные и заменить эти элементы на их квадраты

// Console.WriteLine("Введите размерность m");
// bool isNumber1 = int.TryParse(Console.ReadLine(), out int m);

// Console.WriteLine("Введите размерность n");
// bool isNumber2 = int.TryParse(Console.ReadLine(), out int n);

// if (!isNumber1 || n <= 0 || m <= 0 || !isNumber2)
// {
//     Console.WriteLine("Invalid number");
//     return;
// }

// int[,] result = CreateRandomArray(m, n);
// Print2DArray(result);
// int[,] newResult = GetNewMatrix(result);
// Console.WriteLine();
// Print2DArray(result);

// int[,] CreateRandomArray(int m, int n)
// {
//     int[,] array = new int[m, n];
//     Random random = new Random();

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
            
//                 array[i, j] = random.Next(0 , 10);
            
//         }
//     }
//     return array;
// }

// int[,] GetNewMatrix(int m, int n)
// {
//     int[,] array = new int[m, n];

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (i % 2 == 0 && j % 2 == 0)
//             {
//                 array[i, j] = array[i, j] * array[i, j];
//             }
//         }
//     }
//     return array;
// }

// void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

