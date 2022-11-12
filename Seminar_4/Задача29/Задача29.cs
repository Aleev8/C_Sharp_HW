/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
Заполнение массива производит пользователь.
1, 2, 5, 7, 19-> [1, 2, 5, 7, 19]
6, 1, 33-> [6, 1, 33] */

Console.Write("Введите желаемое количество элементов создаваемого массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Введите элемент массива с индексом {i}:");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.Write("[{0}]", string.Join(", ", array));