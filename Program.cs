//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// void InputArray(int[] array)
// {
//   for (int i = 0; i < array.Length; i++)
//     array[i] = new Random().Next(100, 1000);
// }


// void ReleaseArray(int[] array, int count = 0)
// {
//   foreach (int i in array)
//   {
//     if (i % 2 == 0)
//         count += 1;
//   }
//   Console.Write(count);
// }

// Console.Clear();
// Console.Write("Введите кол-во элементов: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// InputArray(array);
// Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
// Console.Write("Количество четных чисел: ");
// ReleaseArray(array);

//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// void InputArray(int[] array)
// {
//   for (int i = 0; i < array.Length; i++)
//     array[i] = new Random().Next(-10, 11);
// }

// int sum = 0;
// void ReleaseArray(int[] array, int count = 0)
// {
//   for (int i = 1; i < array.Length; i += 2)
//   {
//     sum = sum + array[i];
//   }
//   Console.Write(sum);
// }

// Console.Clear();
// Console.Write("Введите кол-во элементов: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// InputArray(array);
// Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
// Console.Write("Сумма нечётных индексов: ");
// ReleaseArray(array);

// Задайте массив вещественных(дробных) чисел. Найдите разницу между максимальным и минимальным элементов массива.

void InputArray(double [] array)
{
  for (int i = 0; i < array.Length; i++)
    array[i] = new Random().NextDouble();
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = Math.Round(array[i] * 100, 2);
  }
}

void ReleaseArray(double[] array)
{
  double min = array[0];
  double max = array[0];
  for (int i = 1; i < array.Length; i++)
    {
      if (array[i] < min)
        min = array[i];
      if (array[i] > max)
         max = array[i];
    }
  double result = Math.Round(max - min, 2);
  Console.Write(result);
}

Console.Clear();
Console.Write("Введите кол-во элементов: ");
int n = Convert.ToInt32(Console.ReadLine());
double [] array = new double [n];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
Console.Write("Разница между min и max: ");
ReleaseArray(array);