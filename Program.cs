// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// Console.Clear();

// Console.WriteLine("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int n1 = (n / 100) * 100;
// int n2 = (n - (n % 10) - n1) / 10;

// Console.WriteLine($"Второе цифра данного числа: {n2}");

// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// Console.Clear();

// Console.WriteLine("Введите число: ");
// int x = Convert.ToInt32(Console.ReadLine());

// if (x > 1 & x < 6)
//     Console.WriteLine("Это будний день.");
// else if (x < 8 & x > 0)
//     Console.WriteLine("Это выходной.");
// else 
//     Console.WriteLine("Такого дня недели нет.");

// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// Console.Clear();

// Console.WriteLine("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int n1 = 0;

// if (n >= 1000)
// {
//     while(n > 1000)
//     {
//         n = n / 10;
//     }
//     n1 = n % 10;
//     Console.WriteLine(n1);
// }
// else if (n < 100)
// {
//     Console.WriteLine("В этом числе нет 3 цифры.");
// }
// else if (n > 99 || n < 1000)
// {
//     n1 = n % 2;
//     Console.WriteLine(n1);
// }