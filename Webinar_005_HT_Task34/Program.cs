// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void FillArray (int[] array)
{   Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
        array[i] = rnd.Next(100, 1000);
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
    Console.WriteLine();
}

int CountEvenNumber(int[] array)
{
    int countNums = 0;
    for (int i = 0; i < array.Length; i++)
    {
       if (array[i] % 2 == 0) countNums ++; 
    }
    return countNums;
}

Console.Clear();

int[] newArray = new int[12];
FillArray(newArray);
PrintArray(newArray);
Console.WriteLine($"Кол-во четных элементов массива равно {CountEvenNumber(newArray)}");


