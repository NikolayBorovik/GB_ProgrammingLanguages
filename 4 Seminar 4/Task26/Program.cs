// 26. Пр-ма принимает на вход число и выдает кол-во цифр в числе.
// 456 - 3

Console.Clear();

System.Console.WriteLine("Enter your number: ");
int number = int.Parse(Console.ReadLine());

int numOfDigits(int num)
{
        int i = 0;
        for(; num > 0; i++)
        {
            num = num/10;
        }
    return i;
    }

if(number<0)
{
    System.Console.WriteLine("Your number < 0");
}
else if(number == 0)
{
    System.Console.WriteLine("1");
}
else
{
    System.Console.WriteLine(numOfDigits (number));
}

    