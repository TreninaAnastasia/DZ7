// Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int Prompt(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}
int rows = Prompt("Введите количество строк");
int columns = Prompt("Введите количество столбцов");
double [,] aray = NewArray(rows,columns);
PrintArrat(aray);
double[,] NewArray(int m, int n)
{
    double [,] result = new double [m,n];
    for(int e = 0; e < m; e ++)
    {
        for (int j = 0; j < n; j ++)
        {
            result[e,j] = new Random().NextDouble() + new Random().Next(-10,10) ;
            result[e,j] = Math.Round(result[e,j],1); 
        }
        // *10 + new Random().Next()
    }
    return result;
}
void PrintArrat(double[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i ++)
    {
        for (int j = 0; j < arr.GetLength(1); j ++)
        {
            Console.Write(arr[i,j] + " ");
        }
        Console.WriteLine();
    }
}