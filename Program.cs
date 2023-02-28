// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// int Summa(int a, int b)
// {   
//     if (b == 0)
//         return a;
//     return Summa(a - a, b - b) + ((b - a) + 1) * (a + b) / 2;
// }

// Console.Clear();
// Console.Write("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Summa(a, b));

// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// int Akk(int m, int n)
// {   
//     if (m == 0)
//         return n + 1;
//     else if (n == 0 && m > 0)
//         return Akk(m - 1, 1);
//     else
//         return(Akk(m - 1, Akk(m, n - 1)));
// }

// Console.Clear();
// Console.Write("Введите число: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Akk(m, n));