/*Задача 38: Задайте массив вещественных чисел. 
 Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

double DifferenceMinMax(double[] array)
{
    double max = array[0];
    double min = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (max < array[i])
        {
            max = array[i];
        }
        if (min > array[i])
        {
            min = array[i];
        }
    }
    double result = max - min;
    return Math.Round(result, 3);
}

double[] array = new double[8];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().NextDouble() * new Random().Next(1, 10);
}
Console.WriteLine("[{0}]", string.Join("; ", array));
Console.WriteLine($"Разница между MAX и MIN элементом массива = {DifferenceMinMax(array)}");

