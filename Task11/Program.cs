// 11 Напишите программу, которая выводит случайное 
// трезначное число и удаляет вторую цифру этого числа.

Console.Clear();

int num = new Random().Next(100, 1000);
// int a1 = num / 100;
// int a2 = num % 10;

// Console.WriteLine(num);
// Console.WriteLine($"{a1}" + $"{a2}");

int result = (num / 100) * 10 + num % 10;
Console.WriteLine($"{num} -> {result}");
Console.WriteLine($"{num} -> {num / 100}{num % 10}");

