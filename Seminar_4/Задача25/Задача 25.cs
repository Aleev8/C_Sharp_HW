/*Задача 25: Напишите программу, которая принимает на вход два 
числа (A и B) и возводит число A в натуральную степень B. 
Для решения задания использование цикла for является 
обязательным условием. Не использовать встроенный метод 
возведения в степень.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

int GetPow(int numA, int numB)
{
    int pow = numA;
    for (int i = 1; i < numB; i++)
    {
        pow = pow * numA;
    }
    
    return pow;
}

Console.Write("Введите число А: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numB = Convert.ToInt32(Console.ReadLine());

int pow = GetPow(numA, numB);
Console.WriteLine(pow);
