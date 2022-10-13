// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] MatrixArray()
{
    Console.Write("Введите количество строк в массиве: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов в массиве: ");
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
            arr[i, j] = new Random().Next(0, 100);
        }
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void FindPosition(int[,] matrixArray)
{
    Console.Write("Введите номер строки: ");
    int i = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите номер столбца: ");
    int j = Convert.ToInt32(Console.ReadLine());
    if (i < matrixArray.GetLength(0) && j < matrixArray.GetLength(1) && i >= 0 && j >= 0 )
{
    Console.Write($"Значение элемента в строке {i} и столбце {j} равно: {matrixArray[i, j]}");
}
else Console.Write("Элемента с заданной позицией в массиве нет.");
}

int[,] array = MatrixArray();
FillArray(array);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();
FindPosition(array);