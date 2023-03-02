// Задание 33. Задайте массив. Напишите пр-му, которая определяет, присутствует ли заданное число в массиве.

Console.Clear();

int[] array = GetArray(10);

int[] GetArray (int size)
{
    int[] collection = new int[size];
    for (int i = 0; i < size; i++) collection[i] = new Random().Next(-size,size+1);
    return collection;
}

System.Console.WriteLine("Enter a number to check: ");

int num = int.Parse(Console.ReadLine());

void CheckNumInArray (int[] collection, int number)
{
    for (int i = 0; i < collection.Length; i++)
    {
        if(number == collection[i])
        {
        System.Console.WriteLine("There is an equal number in the array");
        return;
        }
    }
    System.Console.WriteLine("There is NO equal number in the array");
}

System.Console.WriteLine(String.Join(" ", array));

CheckNumInArray (array, num);