// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[] CreateArray(int size)
{
    return new int[size];
}

void FillArray(int[] array, int minValue, int maxValue)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
        array[i] = rnd.Next(minValue, maxValue + 1);
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
    Console.WriteLine();
}

int SumEvenIndexNums(int[] array)
{
    int result = 0;
    for (int i = 1; i < array.Length; i+=2)
    {
        result += array[i];
    }
    return result;
}

Console.Clear();

int size = InputNum("Введите размер массива: ");
int[] ints = CreateArray(size);

int min = InputNum("Введите минимальное значение элемента массива: ");
int max = InputNum("Введите максимальное значение элемента массива: ");

FillArray(ints, min, max);
PrintArray(ints);

Console.WriteLine($"Сумма элементов массива с нечетным индексом ровняется {SumEvenIndexNums(ints)}");