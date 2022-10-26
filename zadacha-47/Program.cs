/* Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 */

Console.Write("Введите значение м =   ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите значение n =   ");
int n = int.Parse(Console.ReadLine());
double[,] Array = new double[n, m];
Random rnd = new Random();
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
          Array[i, j] = rnd.Next(-10, 10)+rnd.NextDouble();
          Console.Write($" {Math.Round(Array[i, j], 2)} ");    
        } 
          Console.WriteLine();
    }

