// 55. Задайте 2-мерный массив. Напишите пр-му, кот заменяет строки на столбцы. В случае если это невозожно, 
// пр-ма должна вывести сотв сообщение для пользователя.

Console.Clear();

int GetNum(string numberName)
{
    System.Console.WriteLine($"Enter {numberName}");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

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

int[,] SubstColumnsForRows(int[,] matrix)
{
    int temp;
    for (int i = 0; i < matrix.GetLength(0); i++)         
    {
        for (int j = i; j < matrix.GetLength(1); j++)
        {
            temp = matrix[j,i];
            matrix[j,i] = matrix[i,j];
            matrix[i,j] = temp;
        }
    }
    return matrix;
}

while (true)
{
    int qtyOfRows = GetNum("a number of rows: ");
    int qtyOfColumns = GetNum("a number of columns: ");
    if (qtyOfRows != qtyOfColumns)
        System.Console.WriteLine("The number of rows must be equal to that of the columns");
    else
    {
        int[,] matrix = GetIntMatrix(qtyOfRows, qtyOfColumns);

        PrintMatrix(matrix);
        System.Console.WriteLine();

        SubstColumnsForRows(matrix);

        PrintMatrix(matrix);
        break;
    }
}






