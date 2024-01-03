namespace matrix_for_stanko
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose one");
            Console.WriteLine("1: Multiply by number");
            Console.WriteLine("2: Addition");
            Console.WriteLine("Enter your choice");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("First matrix");
                    double[,] matrix1 = new double[3, 3];
                    double multiply = double.Parse(Console.ReadLine());

                    for (int i = 0; i < matrix1.GetLength(0); i++)
                    {
                        for (int j = 0; j < matrix1.GetLength(1); j++)
                        {
                            matrix1[i, j] = int.Parse(Console.ReadLine());
                            matrix1[i, j] = matrix1[i, j] * multiply;
                        }
                    }

                    for (int i = 0; i < matrix1.GetLength(0); i++)
                    {
                        for (int j = 0; j < matrix1.GetLength(1); j++)
                        {
                            Console.Write(matrix1[i, j] + "\t");
                        }
                        Console.WriteLine();
                    }

                    break;

                case 2:
                    Console.WriteLine("First matrix");
                    double[,] matrix2 = new double[3, 3];

                    for (int i = 0; i < matrix2.GetLength(0); i++)
                    {
                        for (int j = 0; j < matrix2.GetLength(1); j++)
                        {
                            matrix2[i, j] = int.Parse(Console.ReadLine());
                        }
                    }

                    for (int a = 0; a < matrix2.GetLength(0); a++)
                    {
                        for (int b = 0; b < matrix2.GetLength(1); b++)
                        {
                            Console.Write(matrix2[a, b] + "\t");
                        }
                        Console.WriteLine();
                    }

                    Console.WriteLine("Second matrix");
                    double[,] secondMatrix2 = new double[3, 3];

                    for (int p = 0; p < secondMatrix2.GetLength(0); p++)
                    {
                        for (int r = 0; r < secondMatrix2.GetLength(1); r++)
                        {
                            secondMatrix2[p, r] = int.Parse(Console.ReadLine());
                        }
                    }

                    for (int k = 0; k < secondMatrix2.GetLength(0); k++)
                    {
                        for (int l = 0; l < secondMatrix2.GetLength(1); l++)
                        {
                            Console.Write(secondMatrix2[k, l] + "\t");
                        }
                        Console.WriteLine();
                    }

                    double[,] resultMatrix2 = new double[3, 3];

                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            resultMatrix2[i, j] = matrix2[i, j] + secondMatrix2[i, j];
                        }
                        Console.WriteLine();
                    }

                    Console.WriteLine("Final result");

                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            Console.Write(resultMatrix2[i, j] + "\t");
                        }
                        Console.WriteLine();
                    }
                    break;
            }
        }
    }
}