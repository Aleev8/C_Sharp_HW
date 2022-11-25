/*Задача 58: Задайте две матрицы. Напишите программу, которая будет
 находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

void FillArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 11);
        }
    }
}

void PrintArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] +" ");
        }
        Console.WriteLine();
    }
}

int[,] MatrixMultiplication (int[,] firstMatrix, int[,] secondMatrix)
{
    int[,] resultMatrix = new int [firstMatrix.GetLength(0), secondMatrix.GetLength(1)];

    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < secondMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < secondMatrix.GetLength(0); k++)
            {
                resultMatrix[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
            }
            
        }
        
    }
    return resultMatrix;
}

int size = new Random().Next(3, 8);

int[,] testArray1 = new int[size, size];

int[,] testArray2 = new int[size, size];

Console.WriteLine("Задана первая матрица.");
FillArray(testArray1);
PrintArray(testArray1);
Console.WriteLine("Задана вторая матрица.");
FillArray(testArray2);
PrintArray(testArray2);
Console.WriteLine("Результат умножения матриц.");
PrintArray(MatrixMultiplication(testArray1, testArray2));
