// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.Clear();

Console.Write("Введите количество строк : ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов : ");
int columns = int.Parse(Console.ReadLine());

Console.Write("Введите номер строки : ");
int rowsNum = int.Parse(Console.ReadLine());

Console.Write("Введите номер столбца : ");
int columnsNum = int.Parse(Console.ReadLine());

int [,] array = FillArray(rows,columns,1, 10);

PrintArray(array);

if (rowsNum > rows || columnsNum > columns)
    Console.WriteLine("В массиве нет такого элемента. ");
else Console.WriteLine($"Элемент в строке {rowsNum} в столбце {columnsNum} - {array[rowsNum -1, columnsNum -1]}. ");


int [,] FillArray(int rows, int columns, int min, int max)
{
int [,] array = new int [rows, columns];
for (int i = 0; i < rows; i++){
for (int j = 0; j < columns; j++){
array[i,j] = new Random().Next(min,max + 1);
}
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