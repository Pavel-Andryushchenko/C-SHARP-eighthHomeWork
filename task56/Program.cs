// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int GetMinElement(int[] massive)
{
    int minIndex = 0;
    for (int i = 0; i < massive.Length; i++)
    {
        if (massive[i] < massive[minIndex]) {minIndex = i;}
    }
    return minIndex;
}

int[] GetSumLineElements(int[,] matrix)
{
    int[] sumLineElements = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumLineElements[i] +=  matrix[i, j];
        }
    }
    return sumLineElements;
}

void Print2DMassive(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write("{0, 4:f0}", matrix[i,j]);
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
            matrix[i,j] = new Random().Next(startValue, finishValue + 1);
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
int[,] massive = Create2DMassive(m, n, 0, 9);
Print2DMassive(massive);
Console.WriteLine($"Сумма элементов строк: {string.Join(", ", GetSumLineElements(massive))}");
Console.WriteLine($"Строка с наименьшей суммой элементов: {GetMinElement(GetSumLineElements(massive)) + 1}");