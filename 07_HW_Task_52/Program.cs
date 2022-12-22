// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();
Console.Write("Введите количество строк двумерного массива: ");
int numRow = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов двумерного массива: ");
int numCol = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[numRow, numCol];
FillArray(array);
PrintArray(array);

Console.Write("Среднее арифметическое каждого столбца: ");
decimal average;;
for (int j = 0; j < numCol; j++)
{
    average = 0;
    for (int i = 0; i < numRow; i++)
    {
        average = average + array[i,j];
    }
    Console.Write("{0: 0.0}", average/numRow);
    Console.Write(" ");
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