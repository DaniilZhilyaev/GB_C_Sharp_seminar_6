/* Задача 42:** Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10 */

Console.Write("Введите десятичное число: ");
int number10 = int.Parse(Console.ReadLine()!);

Console.Write("Введите систему счисления: ");
int system = int.Parse(Console.ReadLine()!);

Console.WriteLine(ConvertToSystem(number10, system));

string ConvertToSystem(int number, int system)
{
    string result = "";
    string tempstring = "";
    while (number10 != 0)
    {
    tempstring += (number10 % 2).ToString();
    number10 = number10 / 2;
    }
    for (int i = tempstring.Length - 1; i >= 0; i--)
    {
    result += tempstring[i];
    }
    return result;

}



// while (number10 != 0)
// {
//     b = (number10 % 2).ToString();
//     number10 = number10 / 2;
//     a = a + b;
// }

// Console.WriteLine(a);

// for (int i = a.Length - 1; i >= 0; i--)
// {
//     c += a[i];
// }

// Console.WriteLine(c);