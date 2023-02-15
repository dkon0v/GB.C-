// Задайте массив целых чисел. Найдите разницу между максимальным и минимальным элементов массива.//
Console.WriteLine("Введите рамзер массива ");
int size = Convert.ToInt32(Console.ReadLine());
double [] numbers = new double[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("массив: ");
PrintArray(numbers);
  double min = Int32.MaxValue;
  double max = Int32.MinValue;

  for (int g = 0; g < numbers.Length; g++)
  {
    if (numbers[g] > max)
    {
        max = numbers[g];
    }
    if (numbers[g] < min)
    {
        min = numbers[g];
    }
  }
     Console.WriteLine($"всего {number.Lenght} чисел. Максимальное значение = {max}, минимальное значение = {min}");
     Console.WriteLine($"Разница между экстремумами = {max - min}");
       void PrintArray(double[] numbers)
       {
        Console.Write("[ ");
        for (int a = 1; a < numbers.Length; a++)
        {
            Console.Write(numbers[a] + "");
        }
        Console.Write("]");
        Console.Writeline();
       }