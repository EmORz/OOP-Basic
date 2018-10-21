using System;
using System.Linq;

namespace P03_JediGalaxy
{
    class StartUp
    {
        static void Main()
        {
            int[] dimestions = SplitData();
            int[,] matrix = GetMatrix(dimestions);

            string command = Console.ReadLine();
            long sum = 0;
            while (command != "Let the Force be with you")
            {
                int[] ivoCoordinate = GetIvoCoordinate(command);
                int[] evilCoordinate = SplitData();
                int evilX = evilCoordinate[0];
                int evilY = evilCoordinate[1];

                while (evilX >= 0 && evilY >= 0)
                {
                    if (IsInMatrix(matrix, evilX, evilY))
                    {
                        matrix[evilX, evilY] = 0;
                    }
                    evilX--;
                    evilY--;
                }

                int ivoX = ivoCoordinate[0];
                int ivoY = ivoCoordinate[1];

                while (ivoX >= 0 && ivoY < matrix.GetLength(1))
                {
                    if (IsInMatrix(matrix, ivoX, ivoY))
                    {
                        sum += matrix[ivoX, ivoY];
                    }

                    ivoY++;
                    ivoX--;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(sum);

        }

        private static bool IsInMatrix(int[,] matrix, int x, int y)
        {
            return x >= 0 && x < matrix.GetLength(0) && y >= 0 && y < matrix.GetLength(1);
        }

        private static int[] GetIvoCoordinate(string command)
        {
            return command.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        }

        private static int[] SplitData()
        {
            return Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        }

        private static int[,] GetMatrix(int[] dimestions)
        {
            int row = dimestions[0];
            int col = dimestions[1];

            int[,] matrix = new int[row, col];

            int value = 0;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    matrix[i, j] = value++;
                }
            }

            return matrix;
        }
    }
}
