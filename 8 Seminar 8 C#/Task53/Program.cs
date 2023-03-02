// 53. Задайте 2-мерный массив. Напишите программу, кот поменяет местами 1-ю и последнюю строку массива.

Console.Clear();

int[,] GetIntMatrix(int rows, int columns)
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

int[,] matrix = GetIntMatrix(4, 4);

PrintMatrix(matrix);

int[,] SubstituteRows(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        int temp = matrix[0,i];
        matrix[0,i] = matrix[matrix.GetLength(0)-1,i];
        matrix[matrix.GetLength(0)-1,i] = temp;
    }

    return matrix;
}

SubstituteRows(matrix);
System.Console.WriteLine();
PrintMatrix(matrix);

