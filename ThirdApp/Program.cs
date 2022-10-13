// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] MatrixArray()
{
    Console.Write("Введите количество строк в массиве : ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов в массиве : ");
    int columns = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[rows, columns];
    return array;
}
void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(-100, 100);
        }
    }
}

void PrintArray(int[,] arr)
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

void ArithmeticalMean(int[,] arr)
{
    double summa = 0;
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            summa = summa + arr[j, i];
            if (j == (arr.GetLength(0) - 1))
            {
                Console.WriteLine($"Среднее арефметическое стобца {i} равно {Math.Round(summa / (j + 1), 2)}");
            }
        }
    }
}

int[,] array = MatrixArray();
Console.WriteLine();
FillArray(array);
PrintArray(array);
Console.WriteLine();
ArithmeticalMean(array);