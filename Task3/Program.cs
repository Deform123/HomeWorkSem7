// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.Clear();

Console.Write("количество строк в массиве : ");
int rows = int.Parse(Console.ReadLine());

Console.Write("количество столбцов в массиве : ");
int columns = int.Parse(Console.ReadLine());

int [,] array = FillArray(rows,columns, 1, 10);
double [] average = new double[array.Length];

PrintArray(array);

 for (int i = 0, count =0; i < rows; i++)
 {
    double sum = 0;
    for (int j = 0; j < columns; j++)
    {
        sum += array[i,j];
    }
    average[count] = sum / columns;
    Console.WriteLine($"Среднее арифметическое столбца {i + 1} равно {average[count]}. ");
 }

int [,] FillArray(int rows, int columns, int min, int max)
{
    int [,] array = new int [rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++){
            array[i,j] = new Random().Next(min,max + 1);
        }
    return array;
}

void PrintArray(int [,] filledArray){
    for(int i = 0; i < filledArray.GetLength(0); i++)
    {
        for(int j = 0; j < filledArray.GetLength(0); j++)
        {
            Console.Write(filledArray[i,j] + " ");
        }
        Console.WriteLine();
    }
}