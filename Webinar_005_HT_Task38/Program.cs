// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

double[] CreateArray(int size)
{
    return new double[size];
}

void FillArray(double[] array, int minValue, int maxValue)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
        array[i] = Math.Round(rnd.Next(minValue, maxValue) + rnd.NextDouble(),2);
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
    Console.WriteLine();
}

double DifMinMax(double[] array)
{
    double MinNum = array[0];
    double MaxNum = array[0];
    for (int i = 1; i < array.Length; i++)
    {
      if(array[i] < MinNum) MinNum = array[i];
      if(array[i] > MaxNum) MaxNum = array[i];  
    }
    double result = (MaxNum - MinNum);
    return result;
}

Console.Clear();

int size = InputNum("Введите размер массива: ");
double[] ints = CreateArray(size);

int min = InputNum("Введите минимальное значение элемента массива: ");
int max = InputNum("Введите максимальное значение элемента массива: ");

FillArray(ints, min, max);
PrintArray(ints);

Console.WriteLine($"Разница между максимальным и минимальным элементами массива равняется {DifMinMax(ints)}");