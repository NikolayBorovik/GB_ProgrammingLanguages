// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// альтернативный варинат - через методы

int EnterUr (string NumberName)
{
    System.Console.WriteLine($"Enter your {NumberName}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

bool isPalindromeInt (int num)
{
    int temp = num;
    int num2 = num%10;

    while(num > 9)
    {
        num = num/10;
        num2 = num2 * 10 + num%10;
    }

return num2 == temp;
}

int numPalindrome = EnterUr ("Palindrome");

bool isPalindrome = isPalindromeInt(numPalindrome); 

// a++ - одинарный оператора
// a+b - бинарный оператор

string str = isPalindrome ? "is a PALINDROME!" : "is NOT A PALINDROME:("; // тернарный оператор

if(isPalindrome)
{
    str = "is a PALINDROME!";
}
else
{
    str = "is NOT A PALINDROME:(";
}

System.Console.WriteLine($"Your number {numPalindrome} {str}");