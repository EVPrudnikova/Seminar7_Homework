/*Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3 */

int m = Input("m");
int n = Input("n");

double[,] array = new double[m, n];

FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.Write("Среднее арифметическое каждого столбца равно: ");   

for (int i = 0; i < m; i++)
{
    double average = 0;
    for (int j = 0; j < n; j++)
    {
        average += array[j, i];
    }
    Console.Write(Math.Round(average / m, 2) + "; ");   
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

