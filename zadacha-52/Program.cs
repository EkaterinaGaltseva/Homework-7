/* Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

Console.Write("Введите количество столбцов:   ");
int Column = int.Parse(Console.ReadLine());
Console.Write("Введите количество строк  ");
int Lines = int.Parse(Console.ReadLine());
int[,] Array = new int[Lines, Column];
Random rnd = new Random();
    for (int i = 0; i < Lines; i++)
    {
        for (int j = 0; j < Column; j++)
        {
          Array[i, j] = rnd.Next(0, 10);
          Console.Write($" {Array[i, j]} ");    
        } 
          Console.WriteLine();
    }


Console.Write("Среднее арифметическое каждого столбца: ");

for (int i = 0; i < Lines; i++)
{
    double Middle = 0;
    for (int j = 0; j < Column; j++)

        {
            Middle += Array[i, j];
            
        } 
    
    Console.Write($"{(float)Middle / Lines}; "); 
}


