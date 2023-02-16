// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// Console.Write("Введите число: ");
// int m = Convert.ToInt32(Console.ReadLine());
// int count = 0;

// for (int i = 0; i <= m; i++)
// {
//     if (Convert.ToInt32(Console.ReadLine()) > 0)
//         count += 1;
// }
// Console.Write(count);

// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// Console.Clear();

// Console.Write("Введите b1: ");
// double b1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите k1: ");
// double k1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите b2: ");
// double b2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите k2: ");
// double k2 = Convert.ToDouble(Console.ReadLine());

// double x = (b2 - b1) / (k1 - k2);
// double y1 = k1 * x + b1;
// double y2 = k2 * x + b2;
// Console.WriteLine($"({y1}, {y2})");

// По целочисленным координатам вершин треугольника (x1,y1), (x2,y2) и (x3,y3) требуется вычислить его площадь.

// Console.Clear();

// Console.Write("Введите x1: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите y1: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите x2: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите y2: ");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите x3: ");
// int x3 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите y3: ");
// int y3 = Convert.ToInt32(Console.ReadLine());

// int p = (x1 + y1) + (x2 + y2) + (x3 + y3) / 2;
// double S = Convert.ToDouble(Math.Sqrt(p * (p - (x1 + y1)) * p * (p - (x2 + y2)) * p * (p - (x3 + y3))));
// Console.WriteLine(S);