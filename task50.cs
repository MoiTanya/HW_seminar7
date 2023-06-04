// Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве, и возвращает позицию 
//этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void FindElement(int[,] array, int element)
{
    
    int[] x = new int[array.GetLength(0)];
    int[] y = new int[array.GetLength(1)];
    int index = 0;
    bool find = false;
    for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
        {
            if (array[i,j] == element)
            {
                x[index] = i;
                y[index] = j;
                index++;
                find = true;
            }

        }
    }
    if (find == false)
    {
        Console.WriteLine($"{element} -> такого числа в массиве нет");
    }
    else {
        for (int k =0; k<index; k++)
        {
            Console.WriteLine($"{element} -> [{x[k]},{y[k]}]");
        }
        
    }
}

Console.WriteLine("Программа проверки наличия элемента в двумерном массиве");
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
Console.WriteLine("Введите значение элемента, который хотите найти в массиве");
int el = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Помните, что нумерация элементов в массиве начинается с 0, а не с 1");
FindElement(array, el);



