// 24. Пр-ма, кот принимает на вх число A и выдает сумму чисел от 1 до А.
// 7 - 28 (1+2+3+4+5+6+7)

Console.Clear();

System.Console.WriteLine("Enter your number: ");
int numA = int.Parse(Console.ReadLine());

if(numA < 1)
{
    System.Console.WriteLine("The number < 1");
}
else
{
    // int result = GetSum(numA);
    // System.Console.WriteLine($"The sum is {result}");
    System.Console.WriteLine($"The sum is {GetSum(numA)}");
}

int GetSum (int number)
{
    int sum = 0;
    for (int i = 1; i <= number; i++)
    {
        sum += i;
    }
    return sum;
}
