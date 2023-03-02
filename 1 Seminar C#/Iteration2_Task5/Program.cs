// Задача №5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке 
// от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"

Console.Write("Enter your number: ");
string strNumber = Console.ReadLine();
int numberN = Convert.ToInt32(strNumber);
int numberA = numberN * -1;
while(numberN >= numberA)
{
    System.Console.Write(numberA);
    System.Console.Write(" ");
    numberA = numberA + 1;
}
