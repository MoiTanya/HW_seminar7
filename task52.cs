// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void ArithmeticMean (int[,] array)
{
    double[] result = new double[array.GetLength(1)];
    for (int j=0; j<array.GetLength(1); j++)
    {
            for (int i=0; i<array.GetLength(0); i++)
        {
            result[j] = result[j] + array[i,j];
        }
        result[j] = result[j]/(array.GetLength(0));
    }
    Console.WriteLine("Среднее арифметическое каждого столбца: " + String.Join(';', result));
    
}


Console.WriteLine("Программа вычисления среднего арифметического элементов в каждом столбце двумерного массива");
Console.WriteLine("Введите количество строк в массиве");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество элементов в строке (столбцов) в массиве");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m,n];

for (int i=0; i<array.GetLength(0); i++)
{
    for (int j=0; j<array.GetLength(1); j++)
    {
        array[i,j] = new Random().Next(0,10);
        Console.Write(array[i,j]+" ");
    }
    Console.WriteLine();
}
ArithmeticMean(array);
