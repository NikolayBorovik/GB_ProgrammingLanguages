// Задание 32. П-ма замены эл-в массива: положит эл-ты на соотв отриц и наоборот.

Console.Clear();

int[] GetArray (int size)
{
    int[] collection = new int[size];
    for (int i = 0; i < size; i++) collection[i] = new Random().Next(-size,size+1);
    return collection;
}

int[] array = GetArray (25);

System.Console.WriteLine(String.Join(" ", array));

int[] ReverseArray (int[] collection)
{
   for (int i = 0; i < collection.Length; i++)
   {
    collection[i] *= -1;
   }
    return collection;
}

ReverseArray (array);

System.Console.WriteLine(String.Join(" ", array));