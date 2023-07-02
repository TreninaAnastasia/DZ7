// Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого числа в массиве нет


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
int a = Prompt("Введите строку массива ");
int b = Prompt("Введите столбец массива ");
Rez(array, a, b);
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

void Rez (int [,] arr, int a, int b)
{
    int temp = 0;
    int rez = 0;
    for(int i = 0; i < arr.GetLength(0); i ++)
    {
        for (int j = 0; j < arr.GetLength(1); j ++)
        { 
           
            if (a == i && b == j) 
            {
            rez = arr[i,j];
            temp = 1;
            }
        }
    }
    if (temp == 1) Console.WriteLine(rez);
    else Console.WriteLine("Такого числа в массиве нет");
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
