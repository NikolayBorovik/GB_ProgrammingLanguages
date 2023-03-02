// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

Console.Clear();

int GetNum(string numberName)
{
    System.Console.WriteLine($"Enter {numberName}");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int[,] GetMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
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
            System.Console.Write(matrix[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

int EqualIndexesIncrement(int[,] matrix)
{
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (isEven(i, j))
            count += matrix[i, j];
        }
    }
    return count;
}

bool isEven(int i, int j)
{
    return i == j;
}

int rows = GetNum("a number of rows");
int columns = GetNum("a number of columns");

int[,] matrix = GetMatrix(rows, columns);

PrintMatrix(matrix);

System.Console.WriteLine();

int result = EqualIndexesIncrement(matrix);

System.Console.WriteLine(result);