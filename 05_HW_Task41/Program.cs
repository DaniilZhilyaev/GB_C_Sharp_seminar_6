/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. (Можно изучить метод Split.
Пример: stringArray.Split(' ', StringSplitOptions.RemoveEmptyEntries);, где первый аргумент это разделитель чисел, второе обработчик введеной последовательности)
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 4 */

Console.Write("Введите последовательность чисел: ");
string StringArray = Console.ReadLine()!;
string[] array = StringArray.Split(' ', StringSplitOptions.RemoveEmptyEntries);
int possum = Positive(array);
Console.WriteLine($"Чисел больше нуля - {possum}");

// Метод подсчета колличества чисел больше 0
int Positive(string[] array)
{
    int result = 0;
    foreach (var value in array)
    {  
        if (int.Parse(value) > 0) result++;
    }
    return result;
}
