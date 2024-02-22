using System;
using System.Runtime.CompilerServices;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("ReverseHalfPyramid");
        ReverseHalfPyramid();
        Console.WriteLine("Full Pattern");
        FullPattern();
        Console.WriteLine("HalfPyramid");
        HalfPyramid();
    }

    static void HalfPyramid()
    {
        for(int i = 0; i <= 6; i++)
        {
            Console.WriteLine();
            for(int j=0; j <= i; j++)
            {
                Console.Write("*");
            }
        }
        Console.WriteLine();
    }
    static void FullPattern()
    {
        for(int i = 0; i <= 6; i++)
        {
            Console.WriteLine();
            for(int j =0; j <= 6; j++)
            {
                Console.Write("*");
            }
        }      
        Console.WriteLine();  
    }
    static void ReverseHalfPyramid()
    {
        for(int i = 0; i <= 6; i++)
        {
            Console.WriteLine();
            for(int y = 6; y >= i; y--)
            {
                Console.Write("*");
            }
        }
        Console.WriteLine();
    }
}

