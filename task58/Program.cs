// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] GetProductMatrix(int[,] mas1, int[,] mas2)
{

    int[,] Product = new int[mas1.GetLength(0), mas2.GetLength(1)];
    for (int i = 0; i < mas1.GetLength(0); i++)
    {
        for (int j = 0; j < mas2.GetLength(1); j++)
        {
            for (int k = 0; k < mas1.GetLength(0); k++)
            {
                Product[i, j] += mas1[i, k] * mas2[k, j];
            }
        }
    }
    return Product;
}

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

int rows1 = GetInput("Введите колличество строк первой матрицы: ");
int columns1 = GetInput("Введите колличество столбцов первой матрицы: ");
int rows2 = GetInput("Введите колличество строк второй матрицы: ");
int columns2 = GetInput("Введите колличество столбцов второй матрицы: ");
if (columns1 != rows2) Console.WriteLine("Матрицы не согласованы, умножение невозможно");
else
{   Console.WriteLine("Первая матрица:"); 
    int[,] massive1 = Create2DMassive(rows1, columns1, 0, 9);
    Print2DMassive(massive1);
    Console.WriteLine("Вторая матрица:"); 
    int[,] massive2 = Create2DMassive(rows2, columns2, 0, 9);
    Print2DMassive(massive2);
    Console.WriteLine("Результирующая матрица: ");
    Print2DMassive(GetProductMatrix(massive1, massive2));
}
