/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
 * Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/

int VolumeEvenNum(int[] numbers)
{
    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        
        if (numbers[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}



int[] array = new int[16];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 1000);
}
Console.WriteLine("[{0}]", string.Join(", ", array));
Console.WriteLine($"Количество четных чисел в массиве = {VolumeEvenNum(array)}");

