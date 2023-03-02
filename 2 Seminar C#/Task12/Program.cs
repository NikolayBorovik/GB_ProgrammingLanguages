//  Напишите программу, которая будет принимать на вход два числа и выводить, является ли 2-е число кратным первому.
// если не кратно, выводит остаток.

Console.Clear();

System.Console.WriteLine("Enter your 1st number: ");
string? strNumber1 = Console.ReadLine();
int number1 = int.Parse(strNumber1);

System.Console.WriteLine("Enter your 2nd number: ");
string? strNumber2 = Console.ReadLine();
int number2 = int.Parse(strNumber2);

int excess = number1%number2;

if(excess == 0)
{
    System.Console.WriteLine($"Number1   {number1}   is divisible by Number2   {number2}");
}
else 
{
    System.Console.WriteLine($"Number1 {number1} is NOT divisible by Number2 {number2} with the excess = {excess}");
}