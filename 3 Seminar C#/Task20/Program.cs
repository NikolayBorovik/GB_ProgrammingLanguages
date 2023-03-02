// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел
// от 1 до N.

Console.Clear();

System.Console.Write("Enter your number: ");
int number = int.Parse(Console.ReadLine());

int number2 = 1;

while(number >= number2)
{
    System.Console.Write($"{number2}  ");
    double sqr = Math.Pow(number2,2);
    System.Console.WriteLine(sqr);
    number2++;
}
