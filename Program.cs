using System.Runtime.CompilerServices;

Console.WriteLine("Enter number 1:");
string number1 = Console.ReadLine();
Console.WriteLine("Enter number 2:");
string number2 = Console.ReadLine();

Sum sum = new Sum();
Console.WriteLine("Sum = " + sum.sumStrings(number1, number2));


