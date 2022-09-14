// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.Clear();

Console.Write("количество строк в массиве");
int rows = int.Parse(Console.ReadLine());

Console.Write("количество столбцов в массиве");
int columns = int.Parse(Console.ReadLine());

double [,] array2 = new double[rows, columns];

Random rnd = new Random();

FillArray(array2);
Console.WriteLine();
PrintArray(array2);

void FillArray(double [,] array)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++){
            array[i,j] = Convert.ToDouble(rnd.Next(-100, 100) / 10.0);
        }
    }
}

void PrintArray(double [,] array){
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}