// Имеется одномерный массив array из n элементов, требуется найти элемент массива, равный find
// 1. Установить счетчик index в позицию 0
// 2. Если array [index] = find, алгоритм завершил работу успешно.
// 3. Увеличить index на 1
// 4. Если index < n, то перейти к шагу 2. В противном случае алгоритм завершил работу безуспешно.

int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 4, 5, 6 };
int index = 0;
int n = array.Length;

Console.Write("Введите число для поиска: ");
int find = Convert.ToInt32(Console.ReadLine());

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine("Позиция элемента: " + index);
        break;
    }
    index++;
}