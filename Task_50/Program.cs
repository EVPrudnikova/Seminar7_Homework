/*Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

int m = Input("m");
int n = Input("n");
double[,] array = new double[m, n];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int numberRow = NumberPosition("numberRow");
int numberColumn = NumberPosition("numberColumn");

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (numberColumn >= 0 && numberRow >= 0 && numberRow == i && numberColumn == j)
        {
            Console.WriteLine($"Значение элемента равно: {array[numberRow, numberColumn]}");
        }    
    }
        if (numberColumn >= 0 && numberRow >= 0 && numberRow >= m || numberColumn >= n)
        {
            Console.WriteLine("Элемента на такой позиции в массиве нет");
            break;
        }
}

void PrintArray(double[,] matrix)
{
    for (int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matrix.GetLength(1); columns++)
        {
            Console.Write($"{matrix[rows, columns]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(double[,] matrix)
{
    for (int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matrix.GetLength(1); columns++)
        {
            matrix[rows, columns] = new Random().Next(1, 11);
        }
    }
}

int Input(string numberName)
{
    Console.Write($"Введите значение для {numberName}: ");
    return Convert.ToInt32(Console.ReadLine());
}

int NumberPosition(string numberPosition)
{
    Console.Write($"Введите значение для {numberPosition}: ");
    return Convert.ToInt32(Console.ReadLine());
}
