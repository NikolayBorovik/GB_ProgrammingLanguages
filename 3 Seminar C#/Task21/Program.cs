// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 
// 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.Clear();

System.Console.Write("Enter your 1st point X: ");
double point1X = double.Parse(Console.ReadLine());

System.Console.Write("Enter your 1st point Y: ");
double point1Y = double.Parse(Console.ReadLine());

System.Console.Write("Enter your 2nd point X: ");
double point2X = double.Parse(Console.ReadLine());

System.Console.Write("Enter your 2nd point Y: ");
double point2Y = double.Parse(Console.ReadLine());

double result = Math.Sqrt(Math.Pow((point1X - point2X),2) + Math.Pow((point1Y - point2Y),2)); // d = √ (х А – х В) 2 + (у А – у В) 2

System.Console.WriteLine(result.ToString("c2"));

