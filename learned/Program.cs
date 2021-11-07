﻿using System;

namespace learned
{
    class  Program
    {

        static void Main(string[] args)
        {            
            Console.ForegroundColor = ConsoleColor.Blue;
            // Домашняя работа 1:
            //  Задание 1:
            Console.WriteLine("Задание 1:");
            IOHelper.PrintLine(78);
            int numInt = IOHelper.SaveInput(int.MinValue, int.MaxValue,"Введите целое число а");
            double numDouble = IOHelper.SaveInput(double.MinValue, double.MaxValue, "Введите вещественное число b");
            Console.WriteLine(Homework1.GetHelloByeString(numInt, numDouble));            
            IOHelper.PrintLine(78);

            //  Задание 2:
            Console.WriteLine("\nЗадание 2:");
            IOHelper.PrintLine(78);
            numDouble = IOHelper.SaveInput(double.MinValue, double.MaxValue, "Введите число а");
            double numDoubleTwo = IOHelper.SaveInput(double.MinValue, double.MaxValue, "Введите число b");
            Console.WriteLine($"Решение уравнения: {Homework1.EquationSolution(numDouble, numDoubleTwo)}");
            IOHelper.PrintLine(78);

            //  Задание 3:
            Console.WriteLine("\nЗадание 3:");
            IOHelper.PrintLine(78);
            Console.Write("Введите первую строку: ");
            string s1 = Console.ReadLine();
            Console.Write("Введите вторую строку: ");
            string s2 = Console.ReadLine();
            Homework1.SwapStrings(ref s1,ref s2);
            Console.WriteLine($"s1 = {s1}, s2 = {s2}");
            IOHelper.PrintLine(78);

            //  Задание 4:
            Console.WriteLine("\nЗадание 4:");
            IOHelper.PrintLine(78);
            numDouble = IOHelper.SaveInput(double.MinValue, double.MaxValue, "Введите число a");
            numDoubleTwo = IOHelper.SaveInput(double.MinValue, double.MaxValue, "Введите число b");
            double numDoubleThree = IOHelper.SaveInput(double.MinValue, double.MaxValue, "Введите число c");
            Console.WriteLine($"Искомое число Х = {Homework1.FirstDegreeEquationSolution(numDouble, numDoubleTwo, numDoubleThree)}");
            IOHelper.PrintLine(78);
            Console.ReadKey();


            //---------------------------------------------------------------------------------------------------
            // Домашняя работа 2:
            //  Задание 1:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Задание 1:");
            IOHelper.PrintLine(78);
            numInt = IOHelper.SaveInput(100, 999, "Введите трёхзначное число");
            Console.WriteLine($"Сумма цифр равна: {Homework2.GetSumOfDigitsOfNumber(numInt)}");
            IOHelper.PrintLine(78);

            //  Задание 2:
            Console.WriteLine("\nЗадание 2:");
            IOHelper.PrintLine(78);
            numDouble = IOHelper.SaveInput(-Math.Sqrt(double.MaxValue), Math.Sqrt(double.MaxValue), "Введите координаты выстрела: х");
            numDoubleTwo = IOHelper.SaveInput(-Math.Sqrt(double.MaxValue), Math.Sqrt(double.MaxValue), "Введите координаты выстрела: y");
            numDoubleThree = IOHelper.SaveInput(-Math.Sqrt(double.MaxValue), Math.Sqrt(double.MaxValue), "Введите радиус мишени");
            Console.WriteLine(Homework2.GetHitTheTarget(numDouble, numDoubleTwo, numDoubleThree) ? "Попадание" : "Промах");
            IOHelper.PrintLine(78);

            //  Задание 3:
            Console.WriteLine("\nЗадание 3:");
            IOHelper.PrintLine(78);
            numInt = IOHelper.SaveInput(100, 999, "Введите трёхзначное число");
            Console.WriteLine(Homework2.GetMiddleFigureBetween(numInt) ? "Да" : "Нет");
            IOHelper.PrintLine(78);

            //  Задание 4:
            Console.WriteLine("\nЗадание 4:");
            IOHelper.PrintLine(78);
            numInt = IOHelper.SaveInput(100, 999, "Введите трёхзначное число");
            Console.WriteLine(Homework2.GetMirrorNumber(numInt));
            IOHelper.PrintLine(78);

            //  Задание 5:
            Console.WriteLine("\nЗадание 5:");
            IOHelper.PrintLine(78);
            numDouble = IOHelper.SaveInput(double.MinValue, double.MaxValue, "Введите вещественное число");
            Console.WriteLine(Homework2.GetZeroFractionalPart(numDouble) ? "Дробная часть нулевая" : "Дробная часть не нулевая");
            IOHelper.PrintLine(78);
            Console.ReadKey();
            
           
            //---------------------------------------------------------------------------------------------------
            // Домашняя работа 3:
            //  Задание 1:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Задание 1:");
            IOHelper.PrintLine(78);
            numDouble = IOHelper.SaveInput(double.MinValue, double.MaxValue, "Введите число a");
            numDoubleTwo = IOHelper.SaveInput(double.MinValue, double.MaxValue, "Введите число b");
            Console.WriteLine($"Решение: {Homework3.GetFunctionByCondition(numDouble, numDoubleTwo)}");
            IOHelper.PrintLine(78);

            //  Задание 2:
            Console.WriteLine("\nЗадание 2:");
            IOHelper.PrintLine(78);
            numDouble = IOHelper.SaveInput(double.MinValue, double.MaxValue, "Введите координату х");
            numDoubleTwo = IOHelper.SaveInput(double.MinValue, double.MaxValue, "Введите координату y");
            try
            {
                Console.WriteLine($"Точка лежит в {Homework3.DetermineQuadrant(numDouble, numDoubleTwo)} четверти");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Возникла ошибка: {ex.Message}");
            }
            IOHelper.PrintLine(78);

            //  Задание 3:
            Console.WriteLine("\nЗадание 3:");
            IOHelper.PrintLine(78);
            numDouble = IOHelper.SaveInput(double.MinValue, double.MaxValue, "Введите первое число");
            numDoubleTwo = IOHelper.SaveInput(double.MinValue, double.MaxValue, "Введите второе число");
            numDoubleThree = IOHelper.SaveInput(double.MinValue, double.MaxValue, "Введите третье число");
            double[] arr = Homework3.SortingThreeNumbers(numDouble, numDoubleTwo, numDoubleThree);
            Console.WriteLine($"Числа в порядке возрастания: {arr[0]} {arr[1]} {arr[2]}");
            IOHelper.PrintLine(78);

            //  Задание 4:
            Console.WriteLine("\nЗадание 4:");
            IOHelper.PrintLine(78);
            numDouble = IOHelper.SaveInput(double.MinValue, double.MaxValue, "Введите a");
            numDoubleTwo = IOHelper.SaveInput(double.MinValue, double.MaxValue, "Введите b");
            numDoubleThree = IOHelper.SaveInput(double.MinValue, double.MaxValue, "Введите c");
            double[] roots = Homework3.ResolveQuadEquation(numDouble, numDoubleTwo, numDoubleThree);
            if (roots.Length == 1)
                Console.WriteLine($"Один корень: {roots[0]}");
            else if (roots.Length == 2)
                Console.WriteLine($"Два корня: {roots[0]} и {roots[1]}");
            IOHelper.PrintLine(78);

            //  Задание 5:
            Console.WriteLine("\nЗадание 5:");
            IOHelper.PrintLine(78);
            numInt = IOHelper.SaveInput(10, 99, "Введите двухзначное число");
            Console.WriteLine(Homework3.ToStringTwoDigitNumber(numInt));
            IOHelper.PrintLine(78);

            //  Задание 6:
            Console.WriteLine("\nЗадание 6:");
            IOHelper.PrintLine(78);
            numDouble = IOHelper.SaveInput( 0d, double.MaxValue, "Введите первую сторону");
            numDoubleTwo = IOHelper.SaveInput( 0d, double.MaxValue, "Введите вторую сторону");
            numDoubleThree = IOHelper.SaveInput( 0d, double.MaxValue, "Введите третью сторону");
            Console.WriteLine(Homework3.IsRectangle(numDouble, numDoubleTwo, numDoubleThree) ? "Треугольник существует" : "Треугольник не существует");
            IOHelper.PrintLine(78);
            Console.ReadKey();

            
            //---------------------------------------------------------------------------------------------------
            // Домашняя работа 4:
            //  Задание 1:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Задание 1:");
            IOHelper.PrintLine(78);
            numInt = IOHelper.SaveInput(1, 1000, "Введите число");
            Console.WriteLine($"Числа которые без остатка делятся на {numInt} от 1 до 1000");
            ArrayHelper.PrintArray(Homework4.GetNumbersDivided(numInt));
            IOHelper.PrintLine(78);

            //  Задание 2:
            Console.WriteLine("\nЗадание 2:");
            IOHelper.PrintLine(78);
            numInt = IOHelper.SaveInput(1, 10000, "Введите число");
            Console.WriteLine($"Кол-во положительных целых чисел, квадрат которых меньше {numInt}: {Homework4.GetNumbersLessThanASquare(numInt)}");
            IOHelper.PrintLine(78);

            //  Задание 3:
            Console.WriteLine("\nЗадание 3:");
            IOHelper.PrintLine(78);
            numInt = IOHelper.SaveInput(1, 10000, "Введите число");            
            Console.WriteLine($"Максимальный делитель: {Homework4.GetGreatestDivisor(numInt)}");
            IOHelper.PrintLine(78);

            //  Задание 4:
            Console.WriteLine("\nЗадание 4:");
            IOHelper.PrintLine(78);
            numInt = IOHelper.SaveInput(int.MinValue, int.MaxValue, "Введите первое число диапазона");
            int numIntTwo = IOHelper.SaveInput(int.MinValue, int.MaxValue, "Введите второе число диапазона");
            Console.WriteLine($"Сумма чисел из диапазона кратных 7 = {Homework4.GetSumOfMultiplesOf7InARange(numInt, numIntTwo)}");
            IOHelper.PrintLine(78);

            //  Задание 5:
            Console.WriteLine("\nЗадание 5:");
            IOHelper.PrintLine(78);
            numInt = IOHelper.SaveInput(1, 999, "Введите первое число, для нахождения макс. общего делителя");
            numIntTwo = IOHelper.SaveInput(1, 999, "Введите второе число, для нахождения макс. общего делителя");
            Console.WriteLine($"Наибольший общий делитель = {Homework4.FindingTheCommonDivisor(numInt, numIntTwo)}");
            IOHelper.PrintLine(78);

            //  Задание 6:
            Console.WriteLine("\nЗадание 6:");
            IOHelper.PrintLine(78);
            bool flag = false;
            do
            {
                Console.Write("Введите целое положительное число, являющиеся кубом числа: ");
                flag = int.TryParse(Console.ReadLine().Trim(),out numInt);                
            } while (Math.Pow(numInt, (1 / 3f)) % 1 > 0.00001 || numInt < 0 || !flag);            
            Console.WriteLine($"Число {numInt} является кубом числа: {Homework4.FindingTheCubeRoot(numInt)}");
            IOHelper.PrintLine(78);

            //  Задание 7:
            Console.WriteLine("\nЗадание 7:");
            IOHelper.PrintLine(78);
            numInt = IOHelper.SaveInput(10000, 99999999, "Введите число");
            Console.WriteLine($"Число нечётных цифр: {Homework4.GetNumberOfOddDigits(numInt)}");
            IOHelper.PrintLine(78);

            //  Задание 8:
            Console.WriteLine("\nЗадание 8:");
            IOHelper.PrintLine(78);
            numInt = IOHelper.SaveInput(int.MinValue, int.MaxValue, "Введите число");
            Console.WriteLine($"Зеркальным числом, числа {numInt}, является: {Homework4.GetMirrorNumber(numInt)}");
            IOHelper.PrintLine(78);

            //  Задание 9:
            Console.WriteLine("\nЗадание 9:");
            IOHelper.PrintLine(78);
            numInt = IOHelper.SaveInput(1, int.MaxValue, "Введите целое положительное число");
            Console.WriteLine($"Числа в диапазоне от 1 до {numInt}, сумма четных цифр которых больше суммы нечетных:");
            ArrayHelper.PrintArray(Homework4.GetNubbersInRangeSumEvenDigitsGreaterOdd(numInt));
            IOHelper.PrintLine(78);

            //  Задание 10:
            Console.WriteLine("\nЗадание 10:");
            IOHelper.PrintLine(78);
            numInt = IOHelper.SaveInput(int.MinValue+1, int.MaxValue, "Введите первое число");
            numIntTwo = IOHelper.SaveInput(int.MinValue+1, int.MaxValue, "Введите второе число");
            Console.WriteLine(Homework4.GetThereSameNumbers(numInt, numIntTwo) ? "Есть одинаковые цифры" : "Нет одинаковых цифр");
            IOHelper.PrintLine(78);
            Console.ReadKey();

            
            //---------------------------------------------------------------------------------------------------
            // Домашняя работа 5:
            //  Задание 1:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Задание 1:");
            IOHelper.PrintLine(78);
            numInt = IOHelper.SaveInput(1, int.MaxValue, "Введите длину массива");
            int[] arr1 = ArrayHelper.GenerateArrayInt(-99, 99, numInt);
            ArrayHelper.PrintArray(arr1, true, true);
            Homework5.GetNumberOfEvenAndOddElements(arr1, out int cntEven, out int cntOdd);
            Console.WriteLine($"Чётных элементов массива: {cntEven}");
            Console.WriteLine($"Нечётных элементов массива: {cntOdd}");
            IOHelper.PrintLine(78);

            //  Задание 2:
            Console.WriteLine("\nЗадание 2:");
            IOHelper.PrintLine(78);
            numInt = IOHelper.SaveInput(1, int.MaxValue, "Введите длину массива");
            int[] arr2 = ArrayHelper.GenerateArrayInt(-99, 99, numInt);            
            ArrayHelper.PrintArray(arr2,true,true);
            Homework5.ReplaceThirdItemWithTheSumOfThePreviousTwo(arr2);            
            ArrayHelper.PrintArray(arr2);
            IOHelper.PrintLine(78);

            //  Задание 3:
            Console.WriteLine("\nЗадание 3:");
            IOHelper.PrintLine(78);
            numInt = IOHelper.SaveInput(1, int.MaxValue, "Введите длину первого массива");
            int[] arr3One = ArrayHelper.GenerateArrayInt(-99, 99, numInt);
            numInt = IOHelper.SaveInput(1, int.MaxValue, "Введите длину второго массива");
            int[] arr3Two = ArrayHelper.GenerateArrayInt(-99, 99, numInt);            
            ArrayHelper.PrintArray(arr3One,true,true);            
            ArrayHelper.PrintArray(arr3Two,true);            
            int[] arrThree = Homework5.GluingTwoArrays(arr3One, arr3Two);
            ArrayHelper.PrintArray(arrThree);
            IOHelper.PrintLine(78);

            //  Задание 4:
            Console.WriteLine("\nЗадание 4:");
            IOHelper.PrintLine(78);
            numInt = IOHelper.SaveInput(1, int.MaxValue, "Введите длину массива");
            int[] arr4 = ArrayHelper.GenerateArrayInt(-99, 99, numInt);            
            ArrayHelper.PrintArray(arr4,true,true);
            Homework5.SwapFirstAndSecondHalfArray(arr4);         
            ArrayHelper.PrintArray(arr4);
            IOHelper.PrintLine(78);

            //  Задание 5:
            Console.WriteLine("\nЗадание 5:");
            IOHelper.PrintLine(78);
            numInt = IOHelper.SaveInput(1, int.MaxValue, "Введите длину массива");
            int[] arr5 = ArrayHelper.GenerateArrayInt(-99, 99, numInt);          
            ArrayHelper.PrintArray(arr5,false,true);
            numInt = IOHelper.SaveInput(1, int.MaxValue, "Введите на сколько сдвинуть массив вправо");
            Homework5.ShiftArrayToRightByN(arr5, numInt);            
            ArrayHelper.PrintArray(arr5,false,true);
            IOHelper.PrintLine(78);

            //  Задание 6:
            Console.WriteLine("\nЗадание 6:");
            IOHelper.PrintLine(78);
            numInt = IOHelper.SaveInput(1, int.MaxValue, "Введите длину массива");
            int[] arr6 = ArrayHelper.GenerateArrayInt(-99, 99, numInt);
            ArrayHelper.PrintArray(arr6,true,true);
            Homework5.SwapEvenAndOddPosition(arr6);            
            ArrayHelper.PrintArray(arr6);
            IOHelper.PrintLine(78);

            //  Задание 7:
            Console.WriteLine("\nЗадание 7:");
            IOHelper.PrintLine(78);
            numInt = IOHelper.SaveInput(1, int.MaxValue, "Введите длину массива");
            int[] arr7 = ArrayHelper.GenerateArrayInt(-99, 99, numInt);
            ArrayHelper.PrintArray(arr7,true,true);          
            var (max7, sumAfterZero) = Homework5.FindingAbsMaxAndSumAfterZero(arr7);
            Console.WriteLine($"Максимальное абсолютного значение: {max7}");
            Console.WriteLine($"Сумма элементов после нуля: {sumAfterZero}");
            IOHelper.PrintLine(78);

            //  Задание 8:
            Console.WriteLine("\nЗадание 8:");
            IOHelper.PrintLine(78);
            numInt = IOHelper.SaveInput(1, int.MaxValue, "Введите длину массива");
            int[] arr8 = ArrayHelper.GenerateArrayInt(-99, 99, numInt);
            ArrayHelper.PrintArray(arr8,true,true);
            arr8 = Homework5.ShortInsert(arr8);            
            ArrayHelper.PrintArray(arr8);
            IOHelper.PrintLine(78);

            //  Задание 9:
            Console.WriteLine("\nЗадание 9:");
            IOHelper.PrintLine(78);
            numInt = IOHelper.SaveInput(1, int.MaxValue, "Введите длину массива");
            int[] arr9 = ArrayHelper.GenerateArrayInt(-99, 99, numInt);
            ArrayHelper.PrintArray(arr9,true,true);
            Homework5.ShortSelect(arr9);            
            ArrayHelper.PrintArray(arr9);
            IOHelper.PrintLine(78);
            Console.ReadKey();


            //---------------------------------------------------------------------------------------------------
            // Домашняя работа 6:
            //  Задание 1:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Задание 1:");
            IOHelper.PrintLine(78);
            numInt = IOHelper.SaveInput(1, int.MaxValue, "Введите число строк массива");
            numIntTwo = IOHelper.SaveInput(1, int.MaxValue, "Введите число столбцов массива");
            int[,] arr1Tws = ArrayHelper.GenerateArrayInt(1, 999, numInt, numIntTwo);            
            ArrayHelper.PrintArray(arr1Tws,true,true);           
            ArrayHelper.PrintArray(Homework6.InversionFrame(arr1Tws));
            IOHelper.PrintLine(78);

            //  Задание 2:
            Console.WriteLine("\nЗадание 2:");
            IOHelper.PrintLine(78);
            int[,] arrSmarter = Homework6.MultiplicationTable(9);
            ArrayHelper.PrintArray(arrSmarter);
            IOHelper.PrintLine(78);
            
            //  Задание 3:
            Console.WriteLine("\nЗадание 3:");
            IOHelper.PrintLine(78);
            numInt = IOHelper.SaveInput(1, int.MaxValue, "Введите размер шахматной доски");
            char[,] arr3Tws = Homework6.GetChessBoard(numInt);            
            ArrayHelper.PrintArray(arr3Tws,false,true);
            IOHelper.PrintLine(78);
            
            //  Задание 4:
            Console.WriteLine("\nЗадание 4:");
            IOHelper.PrintLine(78);
            numInt = IOHelper.SaveInput(1, int.MaxValue, "Введите число строк массива");
            numIntTwo = IOHelper.SaveInput(1, int.MaxValue, "Введите число столбцов массива");
            int[,] arr4Tws = ArrayHelper.GenerateArrayInt(0, 1, numInt, numIntTwo);          
            ArrayHelper.PrintArray(arr4Tws,true,true);         
            Console.WriteLine(Homework6.RespectedAntiqueRules(arr4Tws) ? "Антиковидное правило не соблюдается" : "Антиковидное правило соблюдается");
            IOHelper.PrintLine(78);
            
            //  Задание 5:
            Console.WriteLine("\nЗадание 5:");
            IOHelper.PrintLine(78);            
            double[,] arr5Tws = ArrayHelper.GenerateArrayDouble(100000, 1000000, 10, 6);
            ArrayHelper.PrintArray(arr5Tws,true);
            var(min5, max5, sumMonths, sumOneShop) = Homework6.GetStoreIncome(arr5Tws);            
            for (int i = 0; i < arr5Tws.GetLength(0); i++)
            {
                Console.WriteLine($"Суммарный доход в {i + 1} магазине равен: {sumOneShop[i]:f2}");
            }
            Console.WriteLine();
            for(int i = 0; i < arr5Tws.GetLength(1); i++)
            {
                Console.WriteLine($"Средний доход в {i + 1} месяце равен: {sumMonths[i] / arr5Tws.GetLength(0):f2}");
            }
            Console.WriteLine($"\nМаксимальный доход среди магазинов равен: {max5:f2}");
            Console.WriteLine($"Минимальный доход среди магазинов равен: {min5:f2}");
            IOHelper.PrintLine(78);

            //  Задание 6:
            Console.WriteLine("\nЗадание 6:");
            IOHelper.PrintLine(78);
            numInt = IOHelper.SaveInput(1, int.MaxValue, "Введите число строк массива");
            numIntTwo = IOHelper.SaveInput(1, int.MaxValue, "Введите число столбцов массива");
            int[,] arr6Tws = ArrayHelper.GenerateArrayInt(-99, 99, numInt, numIntTwo);         
            ArrayHelper.PrintArray(arr6Tws,true,true);
            Console.WriteLine($"Количество элементов массива, которые больше всех своих соседей одновременно: {Homework6.GetMoreThanTheirNeighors(arr6Tws)}");            
            IOHelper.PrintLine(78);
            
            //  Задание 7:
            Console.WriteLine("\nЗадание 7:");
            IOHelper.PrintLine(78);
            numInt = IOHelper.SaveInput(1, int.MaxValue, "Введите размер квадратной матрицы");
            char[,] arr7Tws = Homework6.GetHourglass(numInt);
            ArrayHelper.PrintArray(arr7Tws,false,true);
            IOHelper.PrintLine(78);

            //  Задание 8:
            Console.WriteLine("\nЗадание 8:");
            IOHelper.PrintLine(78);
            numInt = IOHelper.SaveInput(1, int.MaxValue, "Введите число строк первой матрицы");
            numIntTwo = IOHelper.SaveInput(1, int.MaxValue, "Введите число столбцов первой матрицы");
            int [,] arr8OneTws = ArrayHelper.GenerateArrayInt(-99, 99, numInt, numIntTwo);
            numInt = IOHelper.SaveInput(1, int.MaxValue, "Введите число строк второй матрицы");
            numIntTwo = IOHelper.SaveInput(1, int.MaxValue, "Введите число столбцов второй матрицы");
            int[,] arr8TwoTws = ArrayHelper.GenerateArrayInt(-99, 99, numInt, numIntTwo);            
            ArrayHelper.PrintArray(arr8OneTws,true,true);
            ArrayHelper.PrintArray(arr8TwoTws,true);
            try
            {
                long[,] arr8ThreeTws = Homework6.MultiplicationMatrix(arr8OneTws, arr8TwoTws);
                ArrayHelper.PrintArray(arr8ThreeTws);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            IOHelper.PrintLine(78);
            Console.ReadKey();
        }
    }
}

