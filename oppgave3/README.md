# C# .NET - Grunnleggende programmering

## Mål
Bli kjent med arrays i C#

## Demo...

```
namespace Demo;

public class Program
{
    public static void Main(string[] args)
    {
        //OneDimensionalArray();
        //OneDimensionalArray2();
        //OneDimensionalArray3();
        //MultiDimensionalArray();
        //MultiDimensionalArray2();
        //JaggedArray();
    }

    public static void OneDimensionalArray()
    {
        int[] list = new int[3];
        list[0] = 3;
        list[1] = 4;
        list[2] = 5;

        foreach (int i in list)
        {
            Console.Write(i);
        }
    }

    public static void OneDimensionalArray2()
    {
        int[] list = [3, 4, 5];

        foreach (int i in list)
        {
            Console.Write(i);
        }
    }

    public static void OneDimensionalArray3()
    {
        int[] list = { 3, 4, 5 };

        foreach (int i in list)
        {
            Console.Write(i);
        }
    }

    public static void MultiDimensionalArray()
    {
        int[,] list = new int[2, 2];
        list[0,0] = 1;
        list[0,1] = 2;
        list[1,0] = 3;
        list[1,1] = 4;

        foreach (int i in list)
        {
            Console.Write(i);
        }
    }

    public static void MultiDimensionalArray2()
    {
        int[,] list = { {1,2}, {3,4} };

        foreach (int i in list)
        {
            Console.Write(i);
        }
    }

    public static void JaggedArray()
    {
        int[][] list = new int[3][];
        list[0] = [1, 3, 5, 7, 9];
        list[1] = [0, 2, 4, 6];
        list[2] = [11, 22];

        for (int i = 0; i < list.Length; i++)
        {
            Console.Write(i + ": ");
            foreach (int j in list[i])
            {
                Console.Write(j);
                Console.Write(" ");
            }

            Console.WriteLine();
        }
    }
}

```
