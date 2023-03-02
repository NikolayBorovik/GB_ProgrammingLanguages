// 28. Пр-ма, кот принимает на вх число N т выдает произв-е чисел от 1 до N.
// 4 - 24

Console.Clear();

System.Console.WriteLine("Enter your number: ");
int number = int.Parse(Console.ReadLine());

int ProductOfDig(int number)
{
    int sum = 1;
    for(int i = 1; i <= number; i++)
    {
        sum *= i;
    }
    return sum;
}

if(number <=0)
{
    System.Console.WriteLine("Your number <= 0");
}
else
{
System.Console.WriteLine(ProductOfDig(number));
}
