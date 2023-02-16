// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Console.WriteLine("Введите номер строки: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца");
int b = Convert.ToInt32(Console.ReadLine());
int [,] numbers = new int [10,10];
FillArrayRandomNumbers(numbers);

 if(a > numbers.GetLength(0) || a > numbers.GetLength(1))
 {
    Console.WriteLine("Такого элемента нет.");
 }
 else
 {
    Console.WriteLine($"значение элемента {a} строки и {b} столбца равно {numbers[a-1,b-1]}");
 }
PrintArray(numbers);

void FillArrayRandomNumbers(int[,]array)
{
    for(int i = 0;i < array.GetLength(0);i++)
    {
        for (int j = 0; j < array.GetLength(1);j++)
        {
            array [i,j] = new Random().Next(-100, 100)/10;
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }   
        Console.Write("]");
        Console.WriteLine(""); 
    }
}