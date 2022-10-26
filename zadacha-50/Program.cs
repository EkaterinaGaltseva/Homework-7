/* Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет  */


Console.Write("Введите количество столбцов желаемого массива:   ");
int Column = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество строк желаемого массива:  ");
int Lines = Convert.ToInt32(Console.ReadLine());


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

Console.Write("Введите номер столбца:   ");
int MyColumn = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер строки:  ");
int MyLines = Convert.ToInt32(Console.ReadLine());

if (MyLines < Lines && MyColumn < Column)
    {
    int result = Array[MyLines, MyColumn];
    Console.Write($"[{MyLines}, {MyColumn}] -> {result}");
    }
else
    Console.Write($"[{MyLines}, {MyColumn}] -> Такого числа в массиве нет");