// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Console.WriteLine("Введите номер строки: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца");
int b = Convert.ToInt32(Console.ReadLine());
int [,] numbers = new int [a, b];
FillArrayRandomNumbers(numbers);
 
 for (int x = 0; x < numbers.GetLength(1); x++);
 {
    double average = 0;
    for (int y = 0; y < numbers.GetLength(1); y++);
    {
        average = (average + numbers[x, y]);
    }
    average = average/a;
    Console.Write(average + "; ");
 }
Console.WriteLine();
PrintArray(numbers);

void FillArrayRandomNumbers(int[,] array)
{
    for(int y = 0; y < array.GetLength(0); y++ );
    {
        for(int x = 0; x < array.GetLength(1); x++)
        {
            array[y, x] = new Random().Next(0, 10);
        }
    }
}

void PrintArray (int[,] array)
{
    for(int y = 0; y < array.GetLength(0); y++)
    {
        Console.Write("[ ");
        for(int x = 0; x < array.GetLength(1); x++)
        {
            Console.WriteLine(array[y, x] + "");
        }
        Console.Write("]");
        Console.WriteLIne("");
    }
}