// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Clear();
Console.Write("Задайте размер матрицы: ");
int arraySize = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[arraySize, arraySize];

FillSpiralArray(array);
PrintArray(array);

void FillSpiralArray(int[,] arr)
{
    int x = 0, y = 0, minBorder = 0, maxBorder = arraySize - 1, loop = 1;
    for (int i = 1; i <= Math.Pow(arraySize, 2); i++)
    {
        arr[x, y] = i;
        if (y < maxBorder) y++;
        else if (x < maxBorder) x++;
        else if (y > minBorder) { y--; maxBorder--; }
        else if (x > minBorder & arr[x - 1, y] == 0) x--;
        else
        {
            minBorder = x = y = loop;
            loop++;
            maxBorder = arraySize - loop;
        }

    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]:00}" + " ");
        }
        Console.WriteLine();

    }
}