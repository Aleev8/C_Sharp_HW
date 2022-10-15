/* Задача 4: Напишите программу, которая принимает на вход три числа
и выдаёт максимальное из этих чисел.*/
Console.Write("Введите чило №1:");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите чило №2:");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите чило №3:");
int numberC = Convert.ToInt32(Console.ReadLine());
int max = numberA;
if (max < numberB) max = numberB;
if (max < numberC) max = numberC;
Console.Write($"Максимальное из введенных чисел {max}");