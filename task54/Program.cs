// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

void ArrangeArrayElements(int[,] matrix)
{
    int startIndex = 0, maxIndex = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        while (startIndex < matrix.GetLength(1))
        {
            for (int j = startIndex; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] > matrix[i, maxIndex])
                {
                    maxIndex = j;
                }
            }
            int bufer = matrix[i, startIndex];
            matrix[i, startIndex] = matrix[i, maxIndex];
            matrix[i, maxIndex] = bufer;
            startIndex++;
            maxIndex = startIndex;
        }
        startIndex = 0;
        maxIndex = 0;
    }
}

void Print2DMassive(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write("{0, 3:f0}", matrix[i, j]);
        }
        Console.WriteLine();
    }
}

int[,] Create2DMassive(int rows, int columns, int startValue, int finishValue)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(startValue, finishValue + 1);
        }
    }
    return matrix;
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int m = GetInput("Введите колличество строк: ");
int n = GetInput("Введите колличество столбцов: ");
int[,] massive = Create2DMassive(m, n, 0, 99);
Print2DMassive(massive);
ArrangeArrayElements(massive);
Console.WriteLine();
Print2DMassive(massive);