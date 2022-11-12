/*Задача 27: Напишите программу, которая принимает на вход число
 и выдаёт сумму цифр в числе. Для решения задания использование 
 цикла for является обязательным условием
452 -> 11
82 -> 10
9012 -> 12
*/


int SumOfDigits(int number)
{
    int sum = 0;
    for (; number > 0 ;)
    {
        sum = sum + number % 10;
        number /= 10;
    }
    return sum;
}


Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumOfDigits(number));


