// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();
Console.Clear();
Console.Write("Введите количество строк матирицы A (столбцов матрицы B): ");
int numRow = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов матирицы A (строк матрицы B): ");
int numCol = Convert.ToInt32(Console.ReadLine());
int[,] arrayA = new int[numRow, numCol];
int[,] arrayB = new int[numCol, numRow];
int[,] arrayC = new int[numRow, numRow];

Console.WriteLine("Матрица 1: ");
FillArray(arrayA);
PrintArray(arrayA);

Console.WriteLine("Матрица 2: ");
FillArray(arrayB);
PrintArray(arrayB);

Console.WriteLine("Произведение матриц: ");
arrayC = CompositionArrays(arrayA, arrayB);
PrintArray(arrayC);


int[,] CompositionArrays(int[,] arrA, int[,] arrB)
{
    int[,] arrC = new int[numRow, numRow];

    for (int i = 0; i < arrC.GetLength(0); i++)
    {
        for (int j = 0; j < arrC.GetLength(1); j++)
        {
            for (int k = 0; k < arrA.GetLength(1); k++)
            {
  
                    arrC[i, j] = arrC[i, j] + arrA[i, k] * arrB[k, j];
            }
        }
    }
    return arrC;
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