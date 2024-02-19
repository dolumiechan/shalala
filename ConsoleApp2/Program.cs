using System;
class Program
{
    static void Main()
    {
        int[] ints = { 115, 2, 456, 78, 342, 78990, 1 };
        int min = int.MaxValue, max = int.MinValue;
        GetMinAndMax(ints, out min, out max);
        Console.WriteLine($"Минимальный элемент = {min}");
        Console.WriteLine($"Максимальный элемент = {max}");
        int arraySize = 10;
        var newArray = CreateAndFillArray(arraySize, out int sum);
        PrintArray(newArray);
        Console.WriteLine($"Сумма всех элементов массива ={sum}");
        Console.ReadLine();
    }
    static int[] CreateAndFillArray(int arraySize, out int sum)
    {
        Random random = new Random();
        sum = 0;
        int[] array = new int[arraySize];
        int i = 0;
        foreach (var num in array)
        {
            array[i] = random.Next(1, 30);
            sum += array[i];
            i++;
        }
        return array;
    }
    static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine($"Элемент {i} = {array[i]}");
        }
        Console.WriteLine();
    }
    static void GetMinAndMax(int[] ints, out int min, out int max)
    {
        min = int.MaxValue;
        max = int.MinValue;
        foreach (var item in ints)
        {
            if (item < min)
            {
                min = item;
            }
            if (item > max)
            {
                max = item;
            }
        }
    }

}
