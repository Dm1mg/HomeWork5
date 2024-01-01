namespace App_5._1
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
                Console.WriteLine("Введите позицию элемента");
                
                try
                {
                    int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
                    Console.WriteLine(matrix[size[0], size[1]]);
                }
                catch (Exception)
                {
                    Console.WriteLine("Такого элемента нет");
                }

            }

            Console.Clear();
            Console.Write("Введите размер матрицы: ");
            int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
            int[,] matrix = new int[size[0], size[1]];
            InputMatrix(matrix);
            PrintMatrix(matrix);
            Console.WriteLine();
            ReleaseMatrix(matrix);
        }
    }
}
