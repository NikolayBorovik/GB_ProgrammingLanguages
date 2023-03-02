// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
// и замените эти элементы на их квадраты.

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

int[,] EvenIndexesToPow(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (isEven(i, j))
                matrix[i, j] *= matrix[i, j];
        }
    }
    return matrix;
}

bool isEven(int i, int j)
{
    return i % 2 == 0 && j % 2 == 0;
}

int rows = GetNum("a number of rows");
int columns = GetNum("a number of columns");

int[,] matrix = GetMatrix(rows, columns);

PrintMatrix(matrix);

System.Console.WriteLine();

EvenIndexesToPow(matrix);

PrintMatrix(matrix);
