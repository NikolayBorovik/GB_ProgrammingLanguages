// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет

Console.WriteLine("Enter your 1st number: ");
string strNumber1 = Console.ReadLine();
int number1 = Convert.ToInt32(strNumber1);
Console.WriteLine("Enter your 2nd number: ");
string strNumber2 = Console.ReadLine();
int number2 = Convert.ToInt32(strNumber2);
if(number1 / number2 == number2)
{
    Console.WriteLine("Your 2nd number is the square of your 2nd number");
}
else
{
    Console.WriteLine("Your 2nd number is NOT the square of your 2nd number");
}
