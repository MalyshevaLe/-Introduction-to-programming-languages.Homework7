// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5  7    -2   -0,2
// 1   -3,3   8   -9,9
// 8    7,8  -7,1  9

/*double[,] ArrayRandom (int m, int n){      
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = Convert.ToDouble(new Random().Next(-100, 101)/10.0);
        }
    }
    return result;
}


void printArray(double[,] result)
{
    for (int i = 0; i < result.GetLength(0); i++)
        {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            Console.Write($" | {result[i,j]} ");
        }
        Console.WriteLine();
        }
} 

Console.Write("Введите число строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] array = ArrayRandom (m, n);
printArray(array);*/


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

/*int[,] ArrayRandom (int m, int n){      
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(1, 101);
        }
    }
    return result;
}

void printArray(int[,] result)
{
    for (int i = 0; i < result.GetLength(0); i++)
        {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            Console.Write($" | {result[i,j]} ");
        }
        Console.WriteLine();
        }
} 

void findNumber(int[,] result, int number)
{
    string messageResult = "";
    for (int i = 0; i < result.GetLength(0); i++)
        {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            if (result[i,j] == number)
            {
                messageResult = ($"{messageResult} в строке {i+1}, в столбце {j+1}; ");   
            }
        }
    }
    if(messageResult != "") Console.WriteLine ($"Введенное вами число {number} находится"+ messageResult);  //если введенное число встречается несколько раз
    else Console.WriteLine($"Введенное вами число {number} в массиве не найдено");
} 

Console.Write("Введите число строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = ArrayRandom (m, n);
printArray(array);

Console.Write("Введите число для поиска: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

findNumber(array, number);*/



// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] ArrayRandom (int m, int n){      
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(1, 11);
        }
    }
    return result;
}

void printArray(int[,] result)
{
    for (int i = 0; i < result.GetLength(0); i++)
        {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            Console.Write($" | {result[i,j]} ");
        }
        Console.WriteLine();
        }
} 

void AverageColumn(int[,] result)
{
    Console.WriteLine($"Среднее арифметическое элементов массива: ");
    for (int j = 0; j < result.GetLength(1); j++)
    {
        double sum = 0;
        Double Average = 0;    
        for (int i = 0; i < result.GetLength(0); i++)
        {
            sum += result[i,j];   
        }
        Average = Math.Round ((sum/result.GetLength(0)), 2);
        Console.WriteLine($"в столбце № {j+1} = {Average}");     
    }
} 

Console.Write("Введите число строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
int[,] array = ArrayRandom (m, n);
printArray(array);
Console.WriteLine();
AverageColumn(array);