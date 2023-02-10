Console.Write("Enter a number1: ");
int numberA = int.Parse(Console.ReadLine()!);
Console.Write("Enter a number2: ");
int numberB = int.Parse(Console.ReadLine()!);

if(numberA > numberB) 
{
    Console.WriteLine("Max = "+numberA);
    Console.WriteLine("Min = "+numberB);
}
else
{
    Console.WriteLine("Max = "+numberB);
    Console.WriteLine("Min = "+numberA);
}
