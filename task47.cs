// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
Console.WriteLine("Программа создания двумерного массива вещественных чисел");
Console.WriteLine("Введите количество строк в массиве");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество элементов в строке (столбцов) в массиве");
int n = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[m,n];
double number = 0;
for (int i=0; i<array.GetLength(0); i++)
{
    for (int j=0; j<array.GetLength(1); j++)
    {
        number = new Random().Next(-10,100);
        array[i,j] = number/10;
        Console.Write(array[i,j]+" ");
    }
    Console.WriteLine();
}

