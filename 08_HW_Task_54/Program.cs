// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
// элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Clear();
Console.Write("Введите количество строк двумерного массива: ");
int numRow = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов двумерного массива: ");
int numCol = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[numRow, numCol];

FillArray(array);
PrintArray(array);

Console.WriteLine("Итоговый отсортированный массив: ");
if (numCol > 1) SortElementsOfArrayRows(array);
PrintArray(array);

void SortElementsOfArrayRows(int[,] arr)
{
    for (int i = 0; i < numRow; i++)
    {
        for (int j = 0; j < numCol; j++)
        {
            int indexMax = j;
            for (int k = j + 1; k < numCol; k++)
            {
                if (arr[i, indexMax] < arr[i, k]) indexMax = k;
            }
            int temporary = arr[i, indexMax];
            arr[i, indexMax] = arr[i, j];
            arr[i, j] = temporary;
        }
    }
}

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 9);
        }
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}