// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void FillArray(int[] arr)
{
    for (int index = 0; index < arr.Length; index++)
    {
        arr[index] = new Random().Next(100, 999);
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

int CountEven(int[] arr)
{
    int count = 0;
    for (int index = 0; index < arr.Length; index++)
    {
        if (arr[index] % 2 == 0)
        {
            count++;
        };
    }
    return count;
}

Console.Clear();
Console.Write("Введите размер массива: ");
int[] array = new int[Convert.ToInt32(Console.ReadLine())];

FillArray(array);
PrintArray(array);
Console.Write("-> " + CountEven(array));