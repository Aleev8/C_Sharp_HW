/*Задача 52. Запросите от пользователя размерности двумерного массива. 
Напишите метод для заполнения массива случайными числами. 
Напишите метод для поиска ср. арифметического значения каждого столбца.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

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

void ArithmeticMean (int[,] array)
{
    Console.WriteLine("Среднее арифметическое каждого столбца:");
    double sum = 0;
    double result = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            result = 0;
            sum += array[i, j];
        }
        result = sum / array.GetLength(0);
        Console.Write(Math.Round(result, 2) +" ");
        sum = 0;
        
    }
}
Console.WriteLine("Введите размерность двумерного массива.");
Console.Write("Введите M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] testArray = new int[m, n];

FillArray(testArray);
Console.WriteLine();
ArithmeticMean(testArray);