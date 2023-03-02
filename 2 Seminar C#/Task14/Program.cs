// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно
// 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.Clear();

System.Console.WriteLine("Enter your number: ");
string? strNumber = Console.ReadLine();
int number = int.Parse(strNumber);

if(number%7 == 0)
{
    if (number%23 == 0)
    {
        System.Console.WriteLine("Divisible by both");
    }
}
else
{
    System.Console.WriteLine("Not divisible");
}
