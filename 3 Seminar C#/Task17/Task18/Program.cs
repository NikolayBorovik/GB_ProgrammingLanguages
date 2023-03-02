// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат 
// точек в этой четверти (x и y).

Console.Clear();

// while (true)
// {
// System.Console.WriteLine("Enter quarter number ");
// quarter = int.Parse(Console.ReadLine());
// if (quarter >=1 && quarter <= 4)
// {
// break;
// }
// }

System.Console.Write("Enter number of your section: ");
int numSec = int.Parse(Console.ReadLine());

if(numSec == 1)
{
    System.Console.WriteLine("X > 0, Y > 0");
}
else if(numSec == 2)
{
    System.Console.WriteLine("X > 0, Y < 0");
}
else if(numSec == 3)
{
    System.Console.WriteLine("X < 0, Y < 0");
}
else if(numSec == 4)
{
    System.Console.WriteLine("X < 0, Y > 0");
}
else
{
    System.Console.WriteLine("You have entered wrong numbers");
}