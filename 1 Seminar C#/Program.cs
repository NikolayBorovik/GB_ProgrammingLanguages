// Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное на само себя).
// Например: ● 4 -> 16 / ● -3 -> 9 / ● -7 -> 49
// https://metanit.com/sharp/tutorial/2.1.php

Console.Write("Please, enter your number: ");
string strNumber = Console.ReadLine();
int number = Convert.ToInt32(strNumber);
int sqr = number*number;
Console.Write("The square of your number is: ");
Console.WriteLine(sqr);
