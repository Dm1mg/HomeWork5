namespace App_5._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void InputMatrix(int[,] matrix)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                    for (int j = 0; j < matrix.GetLength(1); j++)
                        matrix[i, j] = new Random().Next(0, 10);
            }

            void PrintMatrix(int[,] matrix)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                        Console.Write(matrix[i, j] + "\t");
                    Console.WriteLine();
                }
            }

            void ReleaseMatrix(int[,] matrix)
            {
                int sMax = 0;
                int str = 0;
                for (int i = 0; i < matrix.GetLength(0); i++) {
                    int sum = 0;
                    
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        sum = matrix[i, j] + sum;
                    }
                    if (sum > sMax)
                    {
                        sMax = sum;
                        str = i;
                    }
                }
                Console.WriteLine("Строка с максимальной суммой под № " + (str+1) + " : ");
                for (int j = 0; j < matrix.GetLength(1); j++)
                    Console.Write(matrix[str, j] + "\t");


            }

            Console.Clear();
            Console.Write("Введите размер не квадратной матрицы: ");
            int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
            int[,] matrix = new int[size[0], size[1]];
            InputMatrix(matrix);
            PrintMatrix(matrix);
            Console.WriteLine();
            ReleaseMatrix(matrix);
        }
    }
}
