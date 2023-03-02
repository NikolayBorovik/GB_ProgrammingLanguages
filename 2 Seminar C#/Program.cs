// Задача 10

Console.Clear();

int number = new Random().Next(10,100);
int number1 = number/10;
int number2 = number%10;

System.Console.WriteLine(number);

if(number1 > number2)
{
    System.Console.WriteLine($"The biggest number is {number1}");
}
else if(number1 < number2)
{
    System.Console.WriteLine($"The biggest number is {number2}");
}
else
{
    System.Console.WriteLine("Both numbers are equal");
}

