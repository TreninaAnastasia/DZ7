// Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом
// столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого
// столбца: 4,6; 5,6; 3,6; 3

int Prompt(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}
int rows = Prompt("Введите количество строк");
int colimns = Prompt("Введите количество столбцов");

int[,] array = NewArray(rows,colimns);
PrintArrat(array);
Console.WriteLine();
Promt(array);

int[,] NewArray(int m, int n)
{
    int [,] result = new int [m,n];
    for(int i = 0; i < m; i ++)
    {
        for (int j = 0; j < n; j ++)
        {
            result[i,j] = new Random().Next(0,10);
        }
    }
    return result;
}
void Promt (int[,] arr)
{
    
    for(int j = 0; j < arr.GetLength(1); j ++)
    {
    double avg = 0;
        for (int i = 0; i < arr.GetLength(0); i ++)
        {
            avg += arr[i,j];
        }
        Console.WriteLine($"{avg / arr.GetLength(0)} ");
}
}
void PrintArrat(int[,] arr)
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
