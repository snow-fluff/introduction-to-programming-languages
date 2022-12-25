// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет 
// находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();
Console.Write("Введите количество строк двумерного массива: ");
int numRow = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов двумерного массива: ");
int numCol = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[numRow, numCol];

FillArray(array);
PrintArray(array);

Console.WriteLine("Строка с наименьшей суммой элементов: " + (MinimalSummRowOfArry(array) + 1));

int MinimalSummRowOfArry(int[,] arr)
{
    if (arr.GetLength(0) == 0) return 0;
    int[] arrSummRows = new int[arr.GetLength(0)];

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arrSummRows[i] = arrSummRows[i] + arr[i, j];
        }
    }

    return FindMinElementofArray(arrSummRows);
}

int FindMinElementofArray(int[] arrSum)
{
    if (arrSum.Length == 1) return 0;
    int indexMin = 0;
    for (int i = 1; i < arrSum.Length; i++)
    {
        if (arrSum[i] < arrSum[indexMin]) indexMin = i;
    }
    return indexMin;
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