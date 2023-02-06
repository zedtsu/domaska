// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// Console.Clear();

// Console.WriteLine("Введите 5-значное число: ");
// int n = Convert.ToInt32(Console.ReadLine());

// while (n > 99999 || n < 10000)
// {
//   Console.WriteLine("Вы ошиблись/nВведите 5-значное число: ");
//   n = Convert.ToInt32(Console.ReadLine());
// }

// int n1 = n / 10000;
// int n2 = n % 10;
// if (n1 != n2)
//   Console.WriteLine("Это число не палиндром.");
// else 
// {
//   if (n1 == n2)
//   {
//     int n3 = (n / 1000) - n1 * 10;
//     int n4 = (n / 10) % 10;
//     if(n3 == n4)
//       Console.WriteLine("Данное число палиндром.");
//     else
//       Console.WriteLine("Это число не палиндром.");
//   }
// }
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// Console.Clear();

// Console.WriteLine("Введите x1, y1, z1: ");
// double x1 = Convert.ToDouble(Console.ReadLine());
// double y1 = Convert.ToDouble(Console.ReadLine());
// double z1 = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Введите x2, y2, z2: ");
// double x2 = Convert.ToDouble(Console.ReadLine());
// double y2 = Convert.ToDouble(Console.ReadLine());
// double z2 = Convert.ToDouble(Console.ReadLine());

// double result = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
// Console.WriteLine($"Результат: {Math.Round(result, 2)}");

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// Console.Clear();

// Console.WriteLine("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());

// for (int i = 1; i <= n; i++)
// {
//     int result = i * i * i;
//     Console.Write($"{result} ");
// }