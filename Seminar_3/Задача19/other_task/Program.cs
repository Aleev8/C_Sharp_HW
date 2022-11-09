/*Задача 19: Напишите программу, которая принимает на вход пятизначное
число и проверяет, является ли оно палиндромом.
14212 -> нет
23432 -> да
12821 -> да */

//Принимает на вход пятизначное число
bool IsPolynomial(int number)
{
    string strNumber = number.ToString();

    if (strNumber[0] == strNumber[4] && strNumber[1] == strNumber[3])
    {
        return true;
    }
    return false;
}

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number <= 9999 || number >= 10000)
{
    Console.WriteLine("Некорректное число. Введите (положительное) пятизначное число");
}
else
{
    bool isPolynomial = IsPolynomial(number);
    if (isPolynomial == true)
    {
    Console.WriteLine("это число полиндром!");
    }
    
}

//Это решение не работает до конца !