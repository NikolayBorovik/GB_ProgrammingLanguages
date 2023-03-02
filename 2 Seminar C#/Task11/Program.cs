// Задача 11. Прг-ма, которая выводит случайное 3-значное число и удаляет вторуб цифру этого числа.
// 456

Console.Clear();
int number = new Random().Next(100,1000);
int number1 = number/100*10;
int number2 = number%10;

int result = number1+number2;

System.Console.WriteLine(number);

System.Console.WriteLine(result);
