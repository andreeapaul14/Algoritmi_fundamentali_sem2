using System;

namespace matrice_spirala
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Choose the number of lines for the Matrix : ");
            int MatrixLinesNumber = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Choose the number of Columns for the Matrix : ");
            int MatrixColumnsNumber = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int[,] Matrix = new int[MatrixLinesNumber, MatrixColumnsNumber];
            MatrixElements(Matrix);
            Console.WriteLine();
            DisplayMatrix(Matrix);
            SpiralTravelPrint(MatrixLinesNumber, MatrixColumnsNumber);

        }
        static Random random = new Random();
        private static void MatrixElements(int[,] Matrix)
        {
            for (int i = 0; i < Matrix.GetLength(0); i++)
                for (int j = 0; j < Matrix.GetLength(1); j++)
                    Matrix[i, j] = random.Next(0, 10);

        }
        private static void DisplayMatrix(int[,] Matrix)
        {
            Console.WriteLine("This is the Matrix : ");
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                    Console.Write(Matrix[i, j] + " ");
                Console.WriteLine();
            }
        }
        static void SpiralTravelPrint(int MatrixLinesNumber, int MatrixColumnsNumber)
        {
            int StartingRowIndex = 0;
            int StartingColumnsIndex = 0;
            int[,] Matrix = new int[MatrixLinesNumber, MatrixColumnsNumber];
            int counter = MatrixLinesNumber * MatrixColumnsNumber;
            /*
             * MatrixLinesNumber - indexul rândului de încheiere
             * MatrixColumnsNumber - indexul coloanei de încheiere
            */
            while (StartingRowIndex < MatrixLinesNumber && StartingColumnsIndex < MatrixColumnsNumber)
            {
                //Afiseaza primul rand
                // din randurile ramase
                for (int i = StartingColumnsIndex; i < MatrixColumnsNumber; i++)
                {
                    Matrix[StartingRowIndex, i] = counter;
                    counter--;
                }
                StartingRowIndex++;

                //Afiseaza ultima coloana
                // din coloanele ramase
                for (int i = StartingRowIndex; i < MatrixLinesNumber; i++)
                {
                    Matrix[i, MatrixColumnsNumber - 1] = counter;
                    counter--;
                }
                MatrixColumnsNumber--;

                //Afiseaza ultimul rand
                // din randurile ramase
                if (StartingRowIndex < MatrixLinesNumber)
                {
                    for (int i = MatrixColumnsNumber - 1; i >= 0; i--)
                    {
                        Matrix[MatrixLinesNumber - 1, i] = counter;
                        counter--;
                    }
                    MatrixLinesNumber--;
                }

                //Afiseaza prima cololoana
                // din coloanele ramase
                if (StartingColumnsIndex < MatrixColumnsNumber)
                {
                    for (int i = MatrixLinesNumber - 1; i >= StartingRowIndex; i--)
                    {
                        Matrix[i, StartingColumnsIndex] = counter;
                        counter--;
                    }
                    StartingColumnsIndex++;
                }

            }
            DisplayMatrix(Matrix);
        }

    }
}