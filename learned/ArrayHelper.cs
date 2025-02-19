﻿using System;

namespace learned
{
    static class ArrayHelper
    {
        private static Random _rnd = new();
        static public int[] GenerateArrayInt(int min, int max, int size)
        {
            int[] arr = new int[size];
            for(int i = 0; i < size; i++)            
                arr[i] = _rnd.Next(min, max + 1);
            
            return arr;
        }
        static public int[,] GenerateArrayInt(int min, int max, int rows, int cols)
        {
            int[,] arr = new int[rows, cols];
            for (int i = 0; i < rows; i++)            
                for(int j = 0; j< cols; j++)                
                    arr[i, j] = _rnd.Next(min, max + 1);                              
            
            return arr;
        }

        static public double[] GenerateArrayDouble(int min, int max, int size)
        {
            double[] arr = new double[size];
            for (int i = 0; i < size; i++)            
                arr[i] = _rnd.NextDouble()*(max - min) + min;
            
            return arr;
        }
        static public double[,] GenerateArrayDouble(int min, int max, int rows, int cols)
        {
            double[,] arr = new double[rows, cols];
            for (int i = 0; i < rows; i++)            
                for (int j = 0; j < cols; j++)                
                    arr[i,j] = _rnd.NextDouble() * (max - min) + min;                
            
            return arr;
        }

        static public void PrintArray<T>(T[] arr, bool nextLine = false, bool lineOnTop = false)
        {
            if (lineOnTop) Console.WriteLine();
            foreach (T t in arr)
                Console.Write($"{t} ");
            Console.WriteLine();
            if (nextLine) Console.WriteLine();
        }

        static public void PrintArray<T>(T[,] arr, bool nextLine = false, bool lineOnTop = false)
        {
            if (lineOnTop) Console.WriteLine();            
            for (int i = 0; i < arr.GetLength(0); i++)
            {               
                for (int j = 0; j < arr.GetLength(1); j++)
                    Console.Write($"{arr[i, j]:f2}\t");
                Console.WriteLine();
            }           
            if (nextLine) Console.WriteLine();
        }
    }
}
