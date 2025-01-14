﻿using System;

namespace learned
{
    static public class Homework6
    {
        static public int[,] InversionFrame(int[,] arr)
        {
            if (arr.Length == 1)
                arr[0, 0] *= -1;
            else
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[0, j] *= -1;
                    arr[arr.GetLength(0) - 1, j] *= -1;
                }

                for (int i = 1; i < arr.GetLength(0) - 1; i++)
                {
                    arr[i, 0] *= -1;
                    arr[i, arr.GetLength(1) - 1] *= -1;
                }
            }

            return arr;
        }

        static public int[,] MultiplicationTable(int size)
        {
            if (size < 0)
                throw new ArgumentException("Недопустимый размер матрицы");
            int[,] arr = new int[size, size];
            for (int i = 0; i < arr.GetLength(0); i++)
                for (int j = 0; j < arr.GetLength(1); j++)
                    arr[i, j] = (i + 1) * (j + 1);            

            return arr;
        }

        static public char[,] GetChessBoard(int size)
        {
            if (size < 0)
                throw new ArgumentException("Недопустимый размер матрицы");
            char[,] arr = new char[size, size];
            
            for (int i = 0; i < arr.GetLength(0); i++)            
                for (int j = 0; j < arr.GetLength(1); j++)                
                    arr[i, j] = (arr.GetLength(0) - i + j + 1) % 2 == 0 ? '0' : '1';

            return arr;
        }

        static public bool RespectedAntiqueRules(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)            
                for (int j = 1; j < arr.GetLength(1) - 1; j++)
                    if (arr[i, j] == 1 && (arr[i, j - 1] == 1 || arr[i, j + 1] == 1))
                        return true;            

            return false;
        }

        static public (double, double, double[], double[]) GetStoreIncome(double[,] arr)
        {
            if (arr.GetLength(0) != 10 || arr.GetLength(1) != 6)
                throw new ArgumentException("Размер матриццы 10х6");
            
            double min = double.MaxValue;
            double max = double.MinValue;
            double[] sumMonths = new double[arr.GetLength(1)];
            double[] sumOneShop = new double[arr.GetLength(0)];

            for (int i = 0; i < arr.GetLength(0); i++)            
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    sumOneShop[i] += arr[i, j];
                    sumMonths[j] += arr[i, j];
                    if (max < arr[i, j]) max = arr[i, j];
                    if (min > arr[i, j]) min = arr[i, j];
                    sumOneShop[i] = Math.Round(sumOneShop[i], 9);
                    sumMonths[j] = Math.Round(sumMonths[j], 9);
                }            

            return (min, max, sumMonths, sumOneShop);
        }

        static public int GetMoreThanTheirNeighbors(int[,] arr)
        {
            int cntMax = 0;
            if (arr.Length == 1) return cntMax;
            for (int i = 0; i < arr.GetLength(0); i++)                
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                int adjacentElements = (i > 0 ? arr[i - 1, j] : 0)
                                       + (i < arr.GetLength(0) - 1 ? arr[i + 1, j] : 0)
                                       + (j > 0 ? arr[i, j - 1] : 0)
                                       + (j < arr.GetLength(1) - 1 ? arr[i, j + 1] : 0);
                if (arr[i, j] > adjacentElements)
                    cntMax++;
            }

            return cntMax;
        }

        static public char[,] GetHourglass(int size)
        {
            if (size < 0)
                throw new ArgumentException("Недопустимый размер матрицы");
            char[,] arr = new char[size, size];
            for (int i = 0; i < arr.GetLength(0); i++)            
                for (int j = 0; j < arr.GetLength(1); j++)                
                    if ((i < j && arr.GetLength(1) - j - 1 < i) ||
                        (i > j && arr.GetLength(1) - j - 1 > i))
                        arr[i, j] = '0';
                    else arr[i, j] = '1';

            return arr;
        }

        static public long[,] MultiplicationMatrix(int[,] arrOne, int[,] arrTwo)
        {
            long[,] arrThree = new long[arrOne.GetLength(0), arrTwo.GetLength(1)];
            if (arrOne.GetLength(1) != arrTwo.GetLength(0))
                throw new ArgumentException(
                    "Умножение не возможно! Количество столбцов первой матрицы не ровно количеству строк второй матрицы.");

            for (int i = 0; i < arrOne.GetLength(0); i++)
            for (int j = 0; j < arrTwo.GetLength(1); j++)
            {
                arrThree[i, j] = 0;
                for (int k = 0; k < arrOne.GetLength(1); k++)
                    arrThree[i, j] += arrOne[i, k] * arrTwo[k, j];
            }

            return arrThree;
        }
    }
}