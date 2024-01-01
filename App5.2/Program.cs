namespace App5._1
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
                for (int i = 0; i < matrix.GetLength(1); i++)
                {
                    int buf = matrix[0,i];
                    matrix[0,i] = matrix[matrix.GetLength(0)-1, i];
                    matrix[matrix.GetLength(0)-1, i] = buf;
                }
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                        Console.Write(matrix[i, j] + "\t");
                    Console.WriteLine();
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
