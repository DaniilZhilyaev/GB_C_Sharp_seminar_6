//Напишите программу, которая перевернёт одномерный массив
//(последний элемент будет на первом месте, а первый - на последнем и т.д.)

int[] array = GetArray(10, -100, 100);
Console.WriteLine($"[{String.Join(", ", array)}]");

//Первый метод, деление пополам
void ReverseArray1(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int k = array[i];
        array[i] = array[array.Length - i - 1];
        array[array.Length - i - 1] = k;        
    }

}

ReverseArray1(array);
Console.WriteLine($"[{String.Join(", ", array)}]");

//Второй метод, создание нового массива
int[] ReverseArray2(int[] array)
{
    int[] result = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        result[i] = array[array.Length - i - 1];
    }
    return result;
}

int[] arr = ReverseArray2(array);
Console.WriteLine($"[{String.Join(", ", arr)}]");



// Общий метод для создания одномерного массива
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}