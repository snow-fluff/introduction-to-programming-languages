// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

void FillArray(int[] arr)
{
    for (int index = 0; index < arr.Length; index++)
    {
        arr[index] = new Random().Next(0, 100);
    }
}

void PrintArray(int[] arr)
{
    Console.Write("[ ");
    for (int index = 0; index < arr.Length; index++)
    {
        Console.Write(arr[index] + " ");
    }
    Console.Write("] ");
}

int FindDiffMaxMin(int[] arr)
{
    int max = arr[0];
    int min = arr[0];
    for (int index = 0; index < arr.Length; index++)
    {
        if (max < arr[index])
        {
            max = arr[index];
        };
        if (min > arr[index])
        {
            min = arr[index];
        };
    }
    int diff = max - min;

    return diff;
}

Console.Clear();
Console.Write("Введите размер массива: ");
int[] array = new int[Convert.ToInt32(Console.ReadLine())];

FillArray(array);
PrintArray(array);
Console.Write("-> " + FindDiffMaxMin(array));