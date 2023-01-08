using System;
class Percolation
{
    static void Main(String[] args)
    {
        while (true)
        {

            Console.WriteLine("enter the n");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = init(n);
            print(matrix);
            Console.ReadLine();
            Console.Clear();
            matrix = Result(matrix);
            print(matrix);
            if (percolates(matrix) == true)
            {
                Console.WriteLine("it is percolation");
            }
            else
            {
                Console.WriteLine("it is not percolation");
            }
            Console.WriteLine("numbers of open sites: " + numberOfOpenSites(matrix));
            Console.ReadLine();
            Console.Clear();
        }

    }
    static int[,] init(int n)
    {
        Random rnd = new Random();
        int[,] matrix = new int[n, n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                int x = rnd.Next(2);
                if (x == 0)
                {
                    matrix[i, j] = 2;
                }
                else if (x == 1 && i == 0)
                {
                    matrix[i, j] = 0;
                }
                else if (x == 1)
                {
                    matrix[i, j] = 1;
                }
            }
        }
        return matrix;
    }
    static int[,] Open(int row, int col, int[,] array)
    {
        int a = 2, b = 2, c = 2, d = 2;
        if (row != 0) a = array[row - 1, col];
        if (col != 0) b = array[row, col - 1];
        if (row < array.GetLength(0) - 1) c = array[row + 1, col];
        if (col < array.GetLength(1) - 1) d = array[row, col + 1];
        if (array[row, col] == 1 && (a == 0 || b == 0 || c == 0 || d == 0))
        {
            array[row, col] = 0;
            return array;
        }
        return array;
    }
    static bool isOpen(int row, int col, int[,] array)
    {
        if (array[row, col] == 2) return false;
        return true;
    }
    static bool isFull(int row, int col, int[,] array)
    {
        if (array[row, col] == 1) return false;
        return true;
    }
    static int numberOfOpenSites(int[,] array)
    {
        int count = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] == 0 || array[i, j] == 1)
                {
                    count++;
                }
            }
        }
        return count;
    }
    static bool percolates(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            if (array[array.GetLength(1) - 1, i] == 0)
            {
                return true;
            }
        }
        return false;
    }
    static void print(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == 1)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Write("  ");
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                else if (matrix[i, j] == 2)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Write("  ");
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                else if (matrix[i, j] == 0)
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Write("  ");
                    Console.BackgroundColor = ConsoleColor.Black;
                }

            }
            Console.WriteLine();
        }
    }
    static int[,] Result(int[,] matrix)
    {
        int x = 0;
        while (x < 10)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix = Open(i, j, matrix);
                }
            }
            x++;
        }
        return matrix;
    }
    static void testcase()
    {
        int[,] testArray1 = { { 0, 2, 2, 2 }, { 1, 1, 2, 1 }, { 1, 1, 1, 2 }, { 1, 1, 2, 2 } };
        bool isFullTest1and1Test1 = true;
        bool isOpenTest1and1Test1 = true;
        int numberOfOpenSites1 = 9;
        bool percoclates1 = true;
        int[,] testArray1Traversal1 = Result(testArray1);
        if (isFullTest1and1Test1 == isFull(1, 1, testArray1Traversal1) || isOpenTest1and1Test1 == isOpen(1, 1, testArray1Traversal1) || numberOfOpenSites1 == numberOfOpenSites(testArray1Traversal1) || percoclates1 == percolates(testArray1Traversal1))
        {
            Console.WriteLine("Test 1 Passed");
        }
        else
        {
            Console.WriteLine("Test 1 not Passed");
        }
        int[,] testArray2 = { { 0, 0, 2, 0 }, { 1, 2, 2, 1 }, { 1, 2, 2, 1 }, { 1, 2, 1, 1 } };
        bool isFullTest1and1Test2 = false;
        bool isOpenTest1and1Test2 = false;
        int numberOfOpenSites2 = 10;
        bool percoclates2 = true;
        int[,] testArray1Traversal2 = Result(testArray1);
        if (isFullTest1and1Test2 == isFull(1, 1, testArray1Traversal2) || isOpenTest1and1Test2 == isOpen(1, 1, testArray1Traversal2) || numberOfOpenSites2 == numberOfOpenSites(testArray1Traversal2) || percoclates2 == percolates(testArray1Traversal2))
        {
            Console.WriteLine("Test 2 Passed");
        }
        else
        {
            Console.WriteLine("Test 2 not Passed");
        }
        int[,] testArray3 = { { 0, 2, 0, 2 }, { 1, 2, 1, 2 }, { 1, 1, 2, 1 }, { 2, 2, 1, 2 } };
        bool isFullTest1and1Test3 = false;
        bool isOpenTest1and1Test3 = false;
        int numberOfOpenSites3 = 8;
        bool percoclates3 = false;
        int[,] testArray1Traversal3 = Result(testArray3);
        if (isFullTest1and1Test3 == isFull(1, 1, testArray1Traversal3) || isOpenTest1and1Test3 == isOpen(1, 1, testArray1Traversal3) || numberOfOpenSites3 == numberOfOpenSites(testArray1Traversal3) || percoclates3 == percolates(testArray1Traversal3))
        {
            Console.WriteLine("Test 3 Passed");
        }
        else
        {
            Console.WriteLine("Test 3 not Passed");
        }
    }
}

