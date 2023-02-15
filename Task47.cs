//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.//
Console.WriteLine("Введите количество строк");
int lineVol = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int columnsVol = Convert.ToInt32(Console.ReadLine());
double[,] numbers = new double[lineVol, columnsVol];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);

 void FillArrayRandomNumbers(double[,] array)
 {
    for (int i = 0;i < array.GetLength(0); i++)
    {
        for(int q = 0;q < array.GetLength(0); q++)
        {
            array[i,q] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
 }
void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int q = 0; q < array.GetLength(1); q++)
        {
            Console.Write(array[i, q] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}