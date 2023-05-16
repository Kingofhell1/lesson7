// See https://aka.ms/new-console-template for more information

int programm;
Boolean begin = true;

while (begin)
{
    Console.WriteLine("  ");
    Console.WriteLine("Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.");
    Console.WriteLine("Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.");
    Console.WriteLine("Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.");
    programm = Convert.ToInt32(Console.ReadLine());
    switch(programm)
    {
        case 1:
        //Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
            Console.WriteLine("Введите высоту двумерного массива: ");
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите длину двумерного массива: ");
            int lenght = int.Parse(Console.ReadLine());
            double[,] array = new double[height,lenght];
            //Создание массива с рандомными числами
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for(int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
                }
            }
            //Вывод массива
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for(int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i,j] + " ");
                }
                Console.WriteLine();
            }

        break;
        case 2:
        //Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
        Console.WriteLine("Введите высоту двумерного массива: ");
        int height1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите длину двумерного массива: ");
        int lenght1 = int.Parse(Console.ReadLine());
        int[,] array1 = new int[height1, lenght1];
        FunctionRandomArray(array1);
        FunctionArithmeticMean(array1);
        void FunctionRandomArray(int[,] arr)
        {
            for(int i = 0; i < arr.GetLength(0); i++)
            {
                for(int j = 0; j < arr.GetLength(1); j++)
                {
                    array1[i,j] = new Random().Next(1,10);
                    Console.Write(array1[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
        void FunctionArithmeticMean(int[,] arr, double sum = 0)
        {
            for(int j = 0; j < arr.GetLength(1); j++)
            {
                for(int i = 0; i < arr.GetLength(0); i++)
                {
                    sum += arr[i,j];
                                       
                }
                Console.Write($"{ sum / arr.GetLength(0)} ");
            }
        }
        break;
        case 3:
        //Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
            Console.WriteLine("Введите высоту двумерного массива: ");
            int height2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите длину двумерного массива: ");
            int lenght2 = Convert.ToInt32(Console.ReadLine());
            int[,] array3 = new int[height2, lenght2];
 
            for (int i = 0; i < array3.GetLength(0); i++) 
            {
                 for (int j = 0; j < array3.GetLength(1); j++)
                 {
                     array3[i, j] = Convert.ToInt32(new Random().Next(0,21)); 
                 } 
            }
 
            for (int i = 0; i < array3.GetLength(0); i++) 
            {
                for (int j = 0; j < array3.GetLength(1); j++)
                {
                    Console.Write(array3[i,j] + "\t  ");
                    
                }
                Console.WriteLine();
            }
 
            Console.WriteLine("Введите координаты");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            if (a>height2  && b>lenght2)
            Console.WriteLine("такого числа нет");
            else
            {
            object c = array3.GetValue(a,b);
            Console.WriteLine(c);
            }
        break;
    default:
             begin = false;
             break;
}
}