/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int SumNotEvenElement(int[] number)
{
    int sum = number[0];
    for (int i = 1; i < number.Length; i++)
    {

        if (i % 2 != 0)
        {
            sum += number[i];
        }
    }
    return sum;
}

int[] array = new int[16];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 100);
}
Console.WriteLine("[{0}]", string.Join(", ", array));
Console.WriteLine($"Сумма элементов стоящих на нечетных позициях = {SumNotEvenElement(array)}");
