/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

Console.WriteLine("Заданны уравнения: y = k1 * x + b1, y = k2 * x + b2");
Console.Write("Введите члены уравнений (в последовательности b1, k1, b2 и k2): ");
string StringArray = Console.ReadLine()!;
string[] array = StringArray.Split(' ', StringSplitOptions.RemoveEmptyEntries);

Point(array);

void Point (string[] array)
{
    double x = 0;
    double y = 0;
    double[] result = new double[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        result[i] = Convert.ToDouble(array[i]);
    }
    x = (result[2] - result[0]) / (result[1] - result[3]);
    y = result[1] * x + result[0];
    Console.WriteLine($"({x}; {y})");
}
