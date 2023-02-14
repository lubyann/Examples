// Напишите программу, которая принимает на вход число и проверяет, кратно 
// ли оно одновременно 7 и 23.

// Console.Write("Enter a number1: ");
// int number1 = int.Parse(Console.ReadLine()!);

// if (number1 % 7 == 0 && number1 % 23 == 0)
// {Console.WriteLine($"{number1} -> yes");}
// else 
// { 
//     Console.WriteLine($"{number1} -> no ");
//     if(number1 % 7 == 1 && number1 % 23 == 1)
//         {Console.WriteLine($"{number1} -> no ");}
// }

Console.Write("Enter a number1: ");
int number1 = int.Parse(Console.ReadLine()!);

if (number1 % 7 == 0 && number1 % 23 == 0)
{ Console.WriteLine($"{number1} -> yes"); }
else
{
    Console.WriteLine($"{number1} -> no ");

}