//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.Clear();

int getUserArray(string massege)
{
    Console.Write(massege);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

double[,] CreatArray(int row, int col)
{
    double[,] mat = new double[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            mat[i, j] = new Random().Next(1, 100);
        }
    }
    return mat;
}

void AverageArifmatic(double[,] mat)
{
    double sum = 0;
    for (int i = 0; i < mat.GetLength(1); i++)
    {
        for (int j = 0; j < mat.GetLength(0); j++)
        {
            sum = sum + mat[i, j];
        }
        Console.WriteLine($"Среднеарифметическое {i + 1} столбца: {sum / mat.GetLength(0)}");
        sum = 0;
    }
}

void PrintArray(double[,] mat)
{
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            Console.Write($"{mat[i, j]} ");
        }
        Console.WriteLine();
    }
}

int row = getUserArray("Введите количество строк в матрице: ");
int col = getUserArray("Введите количество столбцов в матрице: ");
double[,] Matrix = CreatArray(row, col);
PrintArray(Matrix);
AverageArifmatic(Matrix);