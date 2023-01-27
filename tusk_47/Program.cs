//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.

Console.Clear();

int GetUserSize(string massege)
{
    Console.Write(massege);
    int a = int.Parse(Console.ReadLine()!);
    return a;
}

double[,] CreatMatrix(int colLenght, int rolLenght)
{
    double[,] matrix = new double[colLenght, rolLenght];
    for (int i = 0; i < colLenght; i++)
    {
        for (int j = 0; j < rolLenght; j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
    return matrix;
}

void PrintMatrix(double[,] mat)
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

int col = GetUserSize("Укажите количество строк: ");
int rol = GetUserSize("Укажите количество колонок: ");

double[,] Matrix = CreatMatrix(col, rol);
PrintMatrix(Matrix);