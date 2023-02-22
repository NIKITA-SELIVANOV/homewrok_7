int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
int[,] matrix = new int[rows, columns];
Random rnd = new Random();

for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
matrix[i, j] = rnd.Next(min, max + 1);
}
}
return matrix;
}

void PrintMatrix(int[,] matrix)
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
void PointAverage (int[,] matrix) {
   int count = 0;
    for (int j = 0; j< matrix.GetLength(0); j++){
    for ( int i = 0;i < matrix.GetLength(1); i++){
    count += matrix[j,i];   
}
Console.WriteLine (count);
    count = 0;
}
}
int[,] array2D = CreateMatrixRndInt(3, 4, -100, 100);
PrintMatrix(array2D);
PointAverage(array2D);


