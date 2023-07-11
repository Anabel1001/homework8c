// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

int [,] array = GetMatrix(3, 4);
PrintMatrix(array);

int minRow = 0;
int sumRow = SumRowNum(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
  int tempSumRow = SumRowNum(array, i);
  if (sumRow > tempSumRow)
  {
    sumRow = tempSumRow;
    minRow = i;
  }
}

Console.WriteLine();
Console.WriteLine($"Cтрокa с наименьшей суммой значений элементов -> {minRow + 1}.");
Console.WriteLine($"Сумма значений элементов строки = {sumRow}.");

int SumRowNum(int[,] array, int i)
{
  int sumLine = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumLine += array[i,j];
  }
  return sumLine;
}