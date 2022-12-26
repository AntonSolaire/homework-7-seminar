// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


// double[,] Create2DRandomArray (int rows, int colomns)
// {
//     double[,] newArray = new double[rows,colomns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < colomns; j++)
//         {
//             newArray[i,j] = new Random().NextDouble() * 20 - 10;
//         }
//     }
//     return newArray;
// }

// void Show2DArray (double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             double result = Math.Round(array[i,j], 1);
//             Console.Write(result + " ");
//         }
//         Console.WriteLine();
//     }
// }


// Console.WriteLine("Введите количество строк");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов:");
// int n = Convert.ToInt32(Console.ReadLine());


// double[,] myArray = Create2DRandomArray(m,n);
// Show2DArray(myArray);



// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


int[,] Create2DRandomArray (int rows, int colomns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows,colomns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colomns; j++)
        {
            newArray[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return newArray;
}

void Show2DArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}


void ShowNumber (int[,] array, int poz1, int poz2)
{   
    if (poz1 > array.GetLength(0) || poz2 > array.GetLength(1)) Console.WriteLine($"По таким координатам не найдено число");
    else Console.WriteLine($"По таким координатам находится число {array[poz1,poz2]}");
}

Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное возможное значение элемента массива:"); 
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимально возможное значение элемента массива:");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите левую границу:");
int poz1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите правую границу:");
int poz2 = Convert.ToInt32(Console.ReadLine());


int[,] myArray = Create2DRandomArray(m,n,min,max);
Show2DArray(myArray);
ShowNumber(myArray, poz1, poz2);