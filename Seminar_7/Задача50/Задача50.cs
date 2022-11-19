/*Задача 50. Напишите программу, которая будет принимать от пользователя
 позицию (M, N) двумерного массива и возвращать значение элемента, 
 стоящего в этой позиции. Если такой позиции в массиве нет, то сообщить
  об этом пользователю. Сгенерировать массив случайным образом. 
Размерность массива определить самостоятельно. 
Использование методов для заполнения массива обязательно. 
Остальное можно реализовать в главной программе.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
M = 1, N = 7 -> В массиве отсутствует элемент в такой позиции.*/



void FillArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 11);
            Console.Write(array[i, j] +" ");
        }
        Console.WriteLine();
    }
}

void PrintArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] +" ");
        }
        Console.WriteLine();
    }
}

void ElementValueTest (int [,] array, int m, int n)
{
    if (m <= array.GetLength(0) && n <= array.GetLength(1))
    {
        Console.Write($" Элемент с индексами [{m}, {n}] = " + array[m, n]);
    }
    else Console.WriteLine($"Элементов с индексами [{m}, {n}] в массиве нет !");
}


Console.Write("Введите идекс M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите индекс N: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] testArray = new int[new Random().Next(3, 8), new Random().Next(3, 8)];

FillArray(testArray);
PrintArray(testArray);
ElementValueTest(testArray, m, n);