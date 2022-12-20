// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();
Console.Write("Введите размер массива: ");
int[] array = new int[Convert.ToInt32(Console.ReadLine())];

FillArray(array);
Console.Write(string.Join(", ", array));
Console.Write(" -> " + FindCount(array));

void FillArray(int[] arr)
{
    for (int index = 0; index < arr.Length; index++)
    {
        Console.Write("Введите " + index + "-е число: ");
        arr[index] = Convert.ToInt32(Console.ReadLine());
    }
}

int FindCount(int[] arr)
{
    int counter = 0;
    for (int index = 0; index < arr.Length; index++)
    {
        if (arr[index] > 0)
        {
            counter++;
        };

    }
    return counter;
}

