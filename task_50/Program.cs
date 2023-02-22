Console.WriteLine("Введите количсетво столбцов матрицы");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количсетво строк матрицы");
int n = Convert.ToInt32(Console.ReadLine());

int[,] CreateMatrixRndInt(int min, int max){

int[,] matrix = new int[m, n]; // 0, 1
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
void ChechIndex (int[,] matrix){
    Console.WriteLine ("Введите столбец индекса: ");
    int i= Convert.ToInt32(Console.ReadLine());
     Console.WriteLine ("Введите строку индекса: ");
    int j = Convert.ToInt32(Console.ReadLine());
          if (i>m && j>n){
            Console.WriteLine("Такого индекса нет");
}
        else{
 
 object c = matrix.GetValue(j,i);
 Console.WriteLine(c);
 }
}
int[,] array2D = CreateMatrixRndInt( -50, 50);
PrintMatrix(array2D);
ChechIndex(array2D);
    
