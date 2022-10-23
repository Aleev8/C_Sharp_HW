/*Задача 19: Напишите программу, которая принимает на вход пятизначное
число и проверяет, является ли оно палиндромом.
14212 -> нет
23432 -> да
12821 -> да */

bool CheckForPolynomial(string number)
{
    
    char firstChar = number[0];
    char lastChar = number[4];
    char secondChar = number[1];
    char secondLastChar = number[3];
    if (firstChar == lastChar && secondChar == secondLastChar)
    {
        return true;
    }
        else return false;
    
}

Console.Write ("Введите пятизначное число: ");
string number = Console.ReadLine();
bool polynomial = CheckForPolynomial(number);
if (polynomial == true)
{
    Console.WriteLine("Число является полиндромом.");
}
else Console.WriteLine("Число не является полиндромом.");