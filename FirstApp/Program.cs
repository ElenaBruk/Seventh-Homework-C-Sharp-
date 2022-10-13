// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] MatrixArray()
{
    Console.Write("Введите количество строк массива: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов массива: ");
    int n = Convert.ToInt32(Console.ReadLine());
    double[,] array = new double[m, n];
    return array;
}
void FillArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = Math.Round(new Random().NextDouble() * 100, 2);
        }
    }
}

void PrintArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "     ");
        }
        Console.WriteLine();
    }
}

double[,] array = MatrixArray();
Console.WriteLine();
FillArray(array);
Console.WriteLine();
PrintArray(array);