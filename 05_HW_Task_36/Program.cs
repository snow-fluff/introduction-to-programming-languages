// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void FillArray(int[] arr)
{
    for (int index = 0; index < arr.Length; index++)
    {
        arr[index] = new Random().Next(-1000, 1000);
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

int CountEvenIndex(int[] arr)
{
    int sum = arr[0];
    int index = 2;
    while (index < arr.Length)
    {
        sum = sum + arr[index];
        index = index + 2;
    }
    return sum;
}

Console.Clear();
Console.Write("Введите размер массива: ");
int[] array = new int[Convert.ToInt32(Console.ReadLine())];

FillArray(array);
PrintArray(array);
Console.Write("-> " + CountEvenIndex(array));