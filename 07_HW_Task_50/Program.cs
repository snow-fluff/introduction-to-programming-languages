// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Clear();
Console.Write("Введите количество строк двумерного массива: ");
int numRow = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов двумерного массива: ");
int numCol = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[numRow, numCol];
FillArray(array);
PrintArray(array);

Console.Write("Введите номер строки для позиции элемента: ");
int positionRow = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца для позиции элемента: ");
int positionCol = Convert.ToInt32(Console.ReadLine());

if (positionRow < numRow & positionCol < numCol & positionRow >= 0 & positionCol >= 0)
{
    Console.WriteLine("Элемент массива [" + positionRow + ", " + positionCol + "] = " + array[positionRow, positionCol]);
}
else
{
    Console.WriteLine("Элемента массива c такой позицией не существует");
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