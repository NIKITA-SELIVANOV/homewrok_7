/*Задайте двумерный массив размером m×n,
 заполненный случайными вещественными числами.*/
 double [,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
double [,] matrix = new double [rows, columns]; 
Random rnd = new  Random();

for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
matrix[i, j] = rnd.NextDouble()*100;
}
}
return matrix;
}

void PrintMatrix(double [,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
Console.Write("|");
for (int j = 0; j < matrix.GetLength(1); j++)
{
if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 3} | ");
else Console.Write($"{matrix[i,j], 3} ");
}
Console.WriteLine("|");
}
}

double [,] array2DD = CreateMatrixRndInt(4, 4, -50, 50);
PrintMatrix(array2DD);