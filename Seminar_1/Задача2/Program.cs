/* Задача 2: Напишите программу, которая на вход принимает 
два числа и выдаёт, какое число большее, а какое меньшее */

Console.Write("Введите чило №1:");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите чило №2:");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA > numberB)
{
Console.WriteLine($"Первое число {numberA} - большее, второе число {numberB} - меньшее ");
}
if (numberA < numberB)
{
    Console.WriteLine($"Второе число {numberB} - большее, первое число {numberA} - меньшее");
}