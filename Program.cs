internal class Program
{
    private static void Main(string[] args)
    {
        void FillArray(int[,] matrix, int minValue = -9, int maxValue = 9)
        {
            maxValue++;
            Random random = new Random();      
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int  j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random.Next(minValue, maxValue);
                }
            }
        }
        void PrintArray(int[,] matrix)
        {
        for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int  j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]}\t");
                }
                Console.WriteLine();
            }  
        }

        void Task54()
        {
            // Задача 54: Задайте двумерный массив. Напишите программу, которая
            // упорядочит по убыванию элементы каждой строки двумерного массива.
            int rows = 4;
            int columns = 6;

            int[,] matrix = new int[rows, columns];

            FillArray(matrix);
            PrintArray(matrix);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    for (int k = 0; k < columns - j -1; k++)
                    {
                        if (matrix[i, k] < matrix[i, k+1])
                        {
                            (matrix[i, k], matrix[i, k+1]) = (matrix[i, k+1], matrix[i, k]);
                        }
                    }
                }
            }
            Console.WriteLine("\nОтсортированный массив:");
            PrintArray(matrix);    
        }
        //Task54();

        void Task56()
        {

            // Задача 56: Задайте прямоугольный двумерный массив. Напишите
            // программу, которая будет находить строку с наименьшей суммой элементов.

            int rows = 4;
            int columns = 5;

            int[,] matrix = new int[rows, columns];

            FillArray(matrix, 0, 9);
            PrintArray(matrix);

            int min_sum = Int32.MaxValue;
            int min_index = 0;


            for (int i = 0; i < rows; i++)
            {
                int sum = 0;
                for (int j = 0; j < columns; j++)
                {
                    sum += matrix[i, j];   
                }

                if (min_sum > sum)
                {
                    min_sum = sum;
                    min_index = i;
                }
                Console.WriteLine($"Минимальная сумма равна {min_sum}. Она в строке {min_index+1}");
            }
        }
        //  Console.Clear();
        //  Task56();

        void Task58()
        {

            //Задача 58: Заполните спирально массив 4 на 4.

            int rows = 4;
            int columns = 4;

            int[,] matrix = new int[rows, columns];

            int i = 0;
            int j = 0;

            int delta_i = 0;
            int delta_j = 1;

            int steps = columns;
            int turns = 0;
            
            for (int k = 0; k < matrix.Length; k++)
            {
                matrix[i, j] = k + 1;
                steps--;

                if (steps == 0)
                {
                    steps = rows - 1 - turns/2;
                    turns++;
                    int temp = -delta_i;
                    delta_i = delta_j;
                    delta_j = temp;
                }

                i += delta_i;
                j += delta_j;
            }
            PrintArray(matrix);
        }
        Console.Clear();
        Task58();

        
  
            

        
    }
}