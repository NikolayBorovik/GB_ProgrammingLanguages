// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

Console.Clear();

int GetNum(string numberName)
{
    System.Console.WriteLine($"Enter {numberName}");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int[,] GetMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i,j] + " ");
        }
        System.Console.WriteLine();
    }
}

int numRows = GetNum("a number of rows");
int numColumns = GetNum("a number of columns");
int numMaxValue = GetNum("a number of the max value");
int numMinValue = GetNum("a number of the min value");

var matrix = GetMatrix(numRows, numColumns, numMinValue, numMaxValue);

PrintMatrix(matrix);

