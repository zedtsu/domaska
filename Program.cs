// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// Console.Clear();

// Console.Write("Введите первое число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int x = Convert.ToInt32(Console.ReadLine());
// int result = 1;
// int i = 1;

// while (i <= x)
// {
//     result = result * n;
//     i++;
// }
// Console.WriteLine(result);

// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// int number = ReadInt("Введите число: ");
// int len = NumberLen(number);
// SumNumbers(number, len);


// // Функция ввода
// int ReadInt(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

// // Функция подсчета цифр в числе
// int NumberLen(int a)
// {
//     int index = 0;
//     while (a > 0)
//     {
//         a /= 10;
//         index++;
//     }
//     return index;
// }

// // Функция вывода суммы цифр в числе
// void SumNumbers(int n, int len)
// {
//     int sum = 0;
//     for (int i = 1; i <= len; i++)
//     {
//         sum += n % 10;
//         n /= 10;
//     }
//     Console.WriteLine(sum);
// }
// 

// Console.Clear();

// Console.Write("Введите количество учеников: ");
// int n = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите рост учеников по убыванию: ");
// int [] array = {100};
// int i = array.Length;

// while (i <= array.Length)
// {
//     array[1] = Convert.ToInt32(Console.ReadLine());
//     i++;
// }
// Console.WriteLine(array);