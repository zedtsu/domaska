// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

// void InputMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(1, 10);
//         }
//     }
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j]}  \t");
//         }
//         Console.WriteLine();
//     }
// }

// void Check(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             for (int f = 0; f < matrix.GetLength(1) - 1; f++)
//             {
//                 if (matrix[i, f] < matrix[i, f + 1])
//                 {
//                     int temp = matrix[i, f + 1];
//                     matrix[i, f + 1] = matrix[i, f];
//                     matrix[i, f] = temp;
//                 }
//             }
//         }
//     }
// }

// Console.Clear();
// Console.Write("Введите размер массива: ");
// int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
// int[,] matrix = new int[size[0], size[1]];
// Console.WriteLine("Начальный массив:");
// InputMatrix(matrix);
// PrintMatrix(matrix);
// Check(matrix);
// Console.WriteLine("Конечный массив: ");
// PrintMatrix(matrix);

// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// void InputMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(1, 10);
//         }
//     }
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j]}  \t");
//         }
//         Console.WriteLine();
//     }
// }

// void Check(int[,] matrix)
// {
//     int sum = 0;
//     int sum1 = 0;
//     int sum2 = 0;
//     for (int i = 0; i < matrix.GetLength(1); i++)
//     {
//         sum += matrix[0, i];
//     }
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++) sum2 += matrix[i, j];
//         if (sum2 < sum)
//         {
//             sum2 = sum;
//             sum1 = i;
//         }
//         sum2 = 0;
//     }
//     Console.Write($"{sum1 + 1} строка");
// }

// Console.Clear();
// Console.Write("Введите размер массива: ");
// int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
// int[,] matrix = new int[size[0], size[1]];
// Console.WriteLine("Начальный массив:");
// InputMatrix(matrix);
// PrintMatrix(matrix);
// Check(matrix);

// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// void Result(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
// {
//   for (int i = 0; i < resultMatrix.GetLength(0); i++)
//   {
//     for (int j = 0; j < resultMatrix.GetLength(1); j++)
//     {
//       int sum = 0;
//       for (int k = 0; k < firstMartrix.GetLength(1); k++)
//       {
//         sum += firstMartrix[i,k] * secomdMartrix[k,j];
//       }
//       resultMatrix[i,j] = sum;
//     }
//   }
// }

// int InputMatrix(string input)
// {
//   Console.Write(input);
//   int output = Convert.ToInt32(Console.ReadLine());
//   return output;
// }

// void CreateArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       array[i, j] = new Random().Next(1, 10);
//     }
//   }
// }

// void WriteArray (int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       Console.Write(array[i,j] + " ");
//     }
//     Console.WriteLine();
//   }
// }

// int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
// int[] size1 = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
// int[] size2 = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
// int[,] firstMartrix = new int[size[0], size[1]];
// CreateArray(firstMartrix);
// Console.WriteLine($"Первая матрица:");
// WriteArray(firstMartrix);
// int[,] secomdMartrix = new int[size1[0], size1[1]];
// CreateArray(secomdMartrix);
// Console.WriteLine($"Вторая матрица:");
// WriteArray(secomdMartrix);
// int[,] resultMatrix = new int[size2[0], size2[1]];
// Result(firstMartrix, secomdMartrix, resultMatrix);
// Console.WriteLine($"Произведение первой и второй матриц:");
// WriteArray(resultMatrix);

// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// int[,,] array = new int[2, 2, 2];

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         for (int k = 0; k < array.GetLength(2); k++)
//         {
//             array[i, j, k] = new Random().Next(1, 36) * new Random().Next(37, 51);
//             if (array[i, j, k] > 999 || array[i, j, k] > 100)
//                 array[i, j, k] = array[i, j, k] / 10;
//                     if (array[i, j, k] > 999 || array[i, j, k] > 100)
//                         array[i, j, k] = array[i, j, k] / 10;
//             else if (array[i, j, k] < 10)
//                 array[i, j, k] = array[i, j, k] * 10;
//         }
//     }
// }

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         for (int k = 0; k < array.GetLength(2); k++)
//             Console.Write($"{array[i, j, k]}({i}, {j}, {k}) \t");
//         Console.WriteLine();
//     }
// }

// Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника.

// void Out(int n)
// {
//     for (int i = 0; i < n; i++)
//     {
//         for (int j = 0; j <= (n - i); j++)
//         {
//             Console.Write(" ");
//         }
//         for (int j = 0; j <= i; j++)
//         {
//             Console.Write(" ");
//             Console.Write(F(i) / (F(j) * F(i - j)));
//         }
//         Console.WriteLine();
//     }
// }

// int F(int n)
// {
//     int i, x = 1;
//     for (i = 1; i <= n; i++)
//     {
//         x *= i;
//     }
//     return x;
// }

// Console.Write("Введите количество строк: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Out(n);

// Напишите программу, которая заполнит спирально массив 4 на 4.

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " \t");
//         }
//         Console.WriteLine();
//     }
// }


// Console.Write("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[size, size];
// int num = 1;
// int i = 0;
// int j = 0;

// while (num <= size * size)
// {
//     array[i, j] = num;
//     if (i <= j + 1 && i + j < size - 1)
//         j++;
//     else if (i < j && i + j >= size - 1)
//         i++;
//     else if (i >= j && i + j > size - 1)
//         j--;
//     else
//         i--;
//     num++;
// }
// PrintArray(array);