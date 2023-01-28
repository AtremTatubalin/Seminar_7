//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.Clear();

int getUserPosition(string massege)
{
    Console.Write(massege);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

double[,] CreatMatrix(int colLengt, int rolLenght)
{
    double[,] Matrix = new double[rolLenght, colLengt];
    for (int i = 0; i < rolLenght; i++)
    {
        for (int j = 0; j < colLengt; j++)
        {
            Matrix[i, j] = new Random().Next(1, 100);
        }
    }
    return Matrix;
}

void printMatrix(double[,] mat)
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

int row = getUserPosition("Задайте количество строк в массиве: ");
int col = getUserPosition("Задайте количество колонок в массиве: ");
int r = getUserPosition("Введите номер строки в массиве: ");
int c = getUserPosition("Введите номер столбца в массиве: ");
double[,] mat = CreatMatrix(col, row);

printMatrix(mat);

if (r *c < row * col)
{
    Console.WriteLine($"Значение позиции [{r}, {c}]: {mat[r, c]}");
}
    

else
{
    Console.WriteLine("Такой позиции не существует.");
}