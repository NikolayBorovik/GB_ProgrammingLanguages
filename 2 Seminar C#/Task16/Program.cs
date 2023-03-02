// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.Clear();

System.Console.WriteLine("Enter your 1st number: ");
string? strNumber1 = Console.ReadLine();
int number1 = int.Parse(strNumber1);

System.Console.WriteLine("Enter your 2nd number: ");
string? strNumber2 = Console.ReadLine();
int number2 = int.Parse(strNumber2);

if (number1/number2 == number2)
{
   System.Console.WriteLine("Yes");
}
else  if(number2/number1 == number1)
{
    System.Console.WriteLine("Yes");
}
else
{
    System.Console.WriteLine("No");
}
