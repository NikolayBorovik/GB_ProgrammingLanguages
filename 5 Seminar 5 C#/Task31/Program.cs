// Задайте массив из 12 эл-тов, заполненный случайными числами из промужетка [-9,9]. Найдите сумму отриц и положит эл-в массива.
// Н-р, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положит чисел равно 29, сумма отриц - -20.

Console.Clear();

int[] array = GetArray(12,9,-9);

int[] GetArray (int size, int maxValue, int minValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue,maxValue+1);
    }
    return array; 
}

System.Console.WriteLine(String.Join(" ", array));

int posSum = 0;
int negSum =0;

foreach (int el in array)
{
    posSum += el > 0 ? el : 0;
    negSum += el < 0 ? el : 0;
}
//  ==
// for(int i = 0; i < array.Length; i++)
// {
//     if(array[i] > 0) posSum += array[i];
//     else 
//     {
//         negSum += array[i];
//     } 
// }

System.Console.WriteLine($"The sum of positive numbers is {posSum}");
System.Console.WriteLine($"The sum of negative numbers is {negSum}");


