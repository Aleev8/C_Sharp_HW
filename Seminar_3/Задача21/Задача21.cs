/*Задача 21: Напишите программу, которая принимает на вход координаты 
двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

// <Возвращ. тип данных> <Наименование метода>(переменные) { тело метода }
// Находит расстояние между точками в 3D простарнстве 

double Distanse(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double distanse = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2) + Math.Pow(z2-z1, 2));
    return distanse;
}

Console.Write ("Введите координаты точки X1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите координаты точки Y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите координаты точки Z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите координаты точки X2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите координаты точки Y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите координаты точки Z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double distanse_points = Distanse (x1, y1, z1, x2, y2, z2);
Console.WriteLine (distanse_points);