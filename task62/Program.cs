// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void Print2DMassive(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write("{0, 4:f0}", matrix[i, j]);
        }
        Console.WriteLine();
    }
}

int[,] Create2DMassive(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    int iBegin = 0, iEnd = 0, jBegin = 0, jEnd = 0;
    int i = 0, j = 0, value = 1;
    while (value <= rows * columns)
    {
        matrix[i, j] = value;
        if (i == iBegin & j < matrix.GetLength(1) - jEnd - 1) { j++; }
        else if (j == matrix.GetLength(1) - jEnd - 1 & i < matrix.GetLength(0) - iEnd - 1) { i++; }
        else if (i == matrix.GetLength(0) - iEnd - 1 & j > jBegin) { j--; }
        else { i--; }
        if ((i == iBegin + 1) & (j == jBegin) & (jBegin != matrix.GetLength(1) - jEnd - 1))
        {
            iBegin++;
            iEnd++;
            jBegin++;
            jEnd++;
        }
        value++;
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
int[,] massive = Create2DMassive(m, n);
Print2DMassive(massive);

