// С помощью ряда Нилаканта (Google в помощь) вычислить значение числа пи. 
// Решение должно быть оформлено в функцию. 
// Функция должна принимать точность - количество знаков после запятой, сколько указал пользователь. 
// Точность расчета не должна сравниваться с уже известным значением числа, то есть цикл останавливается не потому, что Вы точно знаете, что в сотых будет ,14. 
// Вы этого не знаете. 
// Программа должна сама оценить, когда точность достигнута.

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

double NilakantaSeries(int accuracy)
{
    double piNumber = 3;

    if (accuracy <= 0) return piNumber; // Для случая ввода отрицательной или нулевой точности Пи равняется 3.
    
    double sight = 1;
    double count = 2;

    while (true)
    {
        double summand = 4 / (count * (count + 1) * (count + 2));
        if (summand * Math.Pow(10, accuracy) > 1)
        {
            piNumber += sight * summand;
            count += 2;
            sight *= -1;
        }
        else return Math.Round(piNumber, accuracy);
    }
    return Math.Round(piNumber, accuracy);

}
Console.Clear();

int accNum = InputNum("Введите точность вычисления. Какое кол-во знаков после запятой, которое будет вычислять метод: ");

Console.WriteLine($"Число Пи с точностью до {accNum} знака(ов) после запятой методом рядов Нилаканта равняется {NilakantaSeries(accNum)}");