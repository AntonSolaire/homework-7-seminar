// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


double[,] Create2DRandomArray (int rows, int colomns)
{
    double[,] newArray = new double[rows,colomns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colomns; j++)
        {
            newArray[i,j] = new Random().NextDouble() * 20 - 10;
        }
    }
    return newArray;
}

void Show2DArray (double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            double result = Math.Round(array[i,j], 1);
            Console.Write(result + " ");
        }
        Console.WriteLine();
    }
}


Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:");
int n = Convert.ToInt32(Console.ReadLine());


double[,] myArray = Create2DRandomArray(m,n);
Show2DArray(myArray);