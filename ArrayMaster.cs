

public class Triangles

    {
    List<List<string>> cats = new List<List<string>>();
    //string[,] cats = new string[,] { { "TheFirstCat", "1" } };
    const int row = 9;
    const int cellWidth = 3;
    int[,] triangle = new int[row, row];
    Random rand = new Random();

    public void FillTriangle()
    {
        for(int i =0; i < row; i++)
        {
            triangle[i, 0] = 1;
            triangle[i, i] = 1;
        }
        for (int i = 2; i < row; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                triangle[i, j] =
                    triangle[i - 1, j - 1] + triangle[i - 1, j];
            }
        }
    }

    public void PrintTriange()
    {
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < row; j++)
            {
                if (triangle[i, j] != 0)
                {
                    Console.Write($"{triangle[i, j],cellWidth}");
                }
            }
            Console.WriteLine();
        }
    }

    public void PrintTrisPaskalya()
    {
        int col = cellWidth * row;
        for(int n=-1; n < row; n++)
        {
            Console.WriteLine("");
        }
        for(int i = 0; i < row; i++)
        {
            for(int j = 0; j <= i; j++)
            {
                Console.SetCursorPosition(col, i + 1);
                if (triangle[i, j] != 0) Console.Write($"{triangle[i, j],cellWidth}");
                //if (triangle[i, j] % 2!= 0) Console.Write($"*");
                col += cellWidth * 2;
            }
            col = cellWidth * row - cellWidth * (i + 1);
            Console.WriteLine();
        }
    }

    public void PrintTrisSerpinskogo()
    {
        int col = cellWidth * row;
        for(int n=-1; n < row; n++)
        {
            Console.WriteLine("");
        }
        for(int i = 0; i < row; i++)
        {
            for(int j = 0; j <= i; j++)
            {
                Console.SetCursorPosition(col, i + 1);
                //if (triangle[i, j] != 0) Console.Write($"{triangle[i, j],cellWidth}");
                if (triangle[i, j] % 2!= 0) Console.Write($"*");
                col += cellWidth * 2;
            }
            col = cellWidth * row - cellWidth * (i + 1);
            Console.WriteLine();
        }
    }

    public void PrintEmptyTriange()
    {
        int col = cellWidth * row;
        for(int n=-1; n < row; n++)
        {
            Console.WriteLine("");
        }
        for(int i = 0; i < row; i++)
        {
            for(int j = 0; j <= i; j++)
            {
                Console.SetCursorPosition(col, i + 1);
                //if (triangle[i, j] != 0) Console.Write($"{triangle[i, j],cellWidth}");
                if(i+1 == row)
                {
                    if (triangle[i, j] != 0) Console.Write($"*"); //{triangle[i, j],cellWidth}
                }
                else
                {
                    if (triangle[i, j] < 2) Console.Write($"*"); //{triangle[i, j],cellWidth}
                }
                col += cellWidth * 2;
            }
            col = cellWidth * row - cellWidth * (i + 1);
            Console.WriteLine();
        }
    }
}