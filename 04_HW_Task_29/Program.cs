// Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void FillArray(int[] arr)
{
    for (int index = 0; index < arr.Length; index++)
    {
        arr[index] = new Random().Next(1, 1000);
    }
}

void PrintArray(int[] arr)
{
    for (int index = 0; index < arr.Length; index++)
    {
        Console.Write(arr[index] + " ");
    }
}

Console.Write("Введите размер массива: ");
int[] array = new int[Convert.ToInt32(Console.ReadLine())];

FillArray(array);
PrintArray(array);