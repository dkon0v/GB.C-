// Задайте массив заполненный случайными положительными трехзначными числами. //
// Напишите программу, которая покажет количество четных чисел в массиве. //

Console.Writeline("Введите размер массива: ");
int size = Conver.ToInt32(Console.ReadLine());
int [] numbers = new int [size];
RandomNumbers(numbers);
Console.Writeline("В данном массиве");
PrintArray(numbers);
   void RandomNumbers(int[] numbers )
   {
    for (int i = 0; i < size; i++)
    {
        numbers[i] = new Random().Next(100,1000);
    }
   }
        
     int count = 0;
     for (int y = 0; y < numbers.Length; y++)
     {
       if (numbers[y] % 2 == 0)
       count++;
     }
         Console.Writeline($"из {number.Lenght} чисел, {count} четных ");
            
            void PrintArray(int [] number);
            {
                Console.Write("[ ");
                for(int i = 0; i < number.Lenght; i++);
                {
                    Console.Write(numbers[i] + " ");
                }
                Console.Write("]");
                Console.Writeline();
            }

