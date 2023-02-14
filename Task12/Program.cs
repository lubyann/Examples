// Напишите программу, которая будет принимать два числа и выводить,
// является ли второе число кратное первому. Если второе число не кратно числу первому.
// то программа выводит остаток от деления.

Console.Clear();
Console.Write("Enter a number1: ");
double number1 = double.Parse(Console.ReadLine()!);
Console.Write("Enter a number2: ");
double number2 = double.Parse(Console.ReadLine()!);

if(number2 % number1 == 0)
{
    Console.WriteLine($"{number2} кратное {number1}");
}
else if(number2 % number1 ==1)
{
double res = number2 / number1 - number1;
Console.WriteLine(res);
}
