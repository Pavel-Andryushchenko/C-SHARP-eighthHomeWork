// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

bool CheckForUniqum(int[,,] array, int newValue)
{
    foreach (int oldValue in array)
    {
        if (newValue == oldValue)
        {
            return false;
        }    
    }
    return true;
}

void Print3DMassive(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write("{0, 12:f0}", $"{matrix[i, j, k]} ({j},{k},{i})\t");
            }
            Console.WriteLine();
        }
    }
}

int[,,] Create3DMassive(int x, int y, int z, int startValue, int finishValue)
{
    int[,,] matrix = new int[x, y, z];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                int newValue = new Random().Next(startValue, finishValue + 1);
                if (CheckForUniqum(matrix, newValue)) {matrix[i, j, k] = newValue;}
                else {k--;}
            }
        }       
    }
    return matrix;
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int x = GetInput("Введите размерность по оси x: ");
int y = GetInput("Введите размерность по оси y: ");
int z = GetInput("Введите размерность по оси z: ");
int[,,] massive = Create3DMassive(x, y, z, 0, 99);
Print3DMassive(massive);