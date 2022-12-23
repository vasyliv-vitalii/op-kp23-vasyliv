class Percolation
{

    // creates n-by-n grid, with all sites initially blocked
    static void init(int n)

    // opens the site (row, col) if it is not open already
    static void open(int row, int col)

    // is the site (row, col) open?
    static boolean isOpen(int row, int col)

    // is the site (row, col) full?
    static boolean isFull(int row, int col)

    // returns the number of open sites
    static int numberOfOpenSites()

    // does the system percolate?
    static boolean percolates()

    // prints the matrix on the screen
    // The method should display different types of sites (open, blocked, full)
    static void print()

    // test client (optional)
    static static void Main(String[] args)
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


