/*Задача 56: Задайте прямоугольный двумерный массив. Напишите 
программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки
с наименьшей суммой элементов: 1 строка */

void FillArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 11);
        }
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

int RowMinSumElement (int[,] array)
{   
    
    int temp = 0;
    int result = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
         if (i == 0 || sum < temp) 
        {
            temp = sum;
            result = i;
        }
    }
    return result;
}

int[,] testArray = new int[new Random().Next(3, 8), new Random().Next(3, 7)];

FillArray(testArray);
PrintArray(testArray);
Console.WriteLine();
Console.WriteLine($"Индекс строки с наименьшей суммой элементов = {RowMinSumElement(testArray)}");
