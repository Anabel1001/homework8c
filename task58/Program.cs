// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Создание массива
int[,] GetMatrix(int m, int n) 
{
    int[,] matrix = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(0, 10);
        }
    }
    return matrix;
}

// Печать массива
void PrintMatrix(int[,] array) 
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == 0) Console.Write("[");
            if (j < array.GetLength(1) - 1) Console.Write($"{array[i, j],3},");
            else Console.Write($"{array[i, j],3} ]");
        }
        Console.WriteLine();
    }
}


Console.WriteLine("Первая матрица:");
int [,] firstMatrix = GetMatrix(2, 2);
PrintMatrix(firstMatrix);

Console.WriteLine();
Console.WriteLine("Вторая матрица:");
int [,] secondMatrix = GetMatrix(2, 2);
PrintMatrix(secondMatrix);

int[,] resultMatrix = new int[2, 2];
MultiplicationMatrix(firstMatrix, secondMatrix, resultMatrix);
Console.WriteLine();
Console.WriteLine($"Произведение двух матриц:");
PrintMatrix(resultMatrix);

void MultiplicationMatrix(int[,] firstMatrix, int[,] secondMatrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMatrix.GetLength(1); k++)
      {
        sum += firstMatrix[i, k] * secondMatrix[k, j];
      }
      resultMatrix[i, j] = sum;
    }
  }
}
