﻿using System;
using Sort;

namespace _2._1._27
{
    /*
     * 2.1.27
     * 
     * 希尔排序的用时是次平方级的。
     * 在你的计算机上用 SortCompare 比较希尔排序和插入排序以及选择排序。
     * 测试数组的大小按照 2 的幂次递增，从 128 开始。
     * 
     */
    class Program
    {
        static void Main(string[] args)
        {
            int n = 128;
            Random random = new Random();

            double shellPrev = 1;
            double insertionPrev = 1;
            double selectionPrev = 1;


            while (n < 65538)
            {
                int[] testShell = new int[n];
                int[] testInsertion = new int[n];
                int[] testSelection = new int[n];

                for (int i = 0; i < n; i++)
                {
                    testShell[i] = random.Next();
                    testInsertion[i] = testShell[i];
                    testSelection[i] = testShell[i];
                }

                Console.WriteLine("数组大小：" + n);

                Console.Write("Shell Sort:");
                double shellNow = SortCompare.Time(new ShellSort(), testShell);
                Console.WriteLine(shellNow + "\t\tNow/Prev=" + shellNow / shellPrev);
                Console.Write("Insertion Sort:");
                double insertionNow = SortCompare.Time(new InsertionSort(), testInsertion);
                Console.WriteLine(insertionNow + "\tNow/Prev=" + insertionNow / insertionPrev);
                Console.Write("Selection Sort:");
                double selectionNow = SortCompare.Time(new SelectionSort(), testSelection);
                Console.WriteLine(selectionNow + "\tNow/Prev=" + selectionNow / selectionPrev);
                Console.WriteLine();

                shellPrev = shellNow;
                insertionPrev = insertionNow;
                selectionPrev = selectionNow;

                n *= 2;
            }
        }
    }
}
