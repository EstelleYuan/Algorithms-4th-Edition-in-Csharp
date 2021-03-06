﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortData;

namespace SortUnionTest
{
    [TestClass]
    public class ProblemUnionTest
    {
        [TestMethod]
        public void ShellSort11Test()
        {
            int[] unsorted = DataManager.GetUnsortedData();
            int[] sorted = DataManager.GetSortedData();

            _2._1._11.ShellSort sort = new _2._1._11.ShellSort();
            sort.Sort(unsorted);
            for (int i = 0; i < unsorted.Length; i++)
            {
                Assert.AreEqual(unsorted[i], sorted[i]);
            }
        }

        [TestMethod]
        public void ShellSort12Test()
        {
            int[] unsorted = DataManager.GetUnsortedData();
            int[] sorted = DataManager.GetSortedData();

            _2._1._12.ShellSort sort = new _2._1._12.ShellSort();
            sort.Sort(unsorted);
            for (int i = 0; i < unsorted.Length; i++)
            {
                Assert.AreEqual(unsorted[i], sorted[i]);
            }
        }

        [TestMethod]
        public void ShellSort19Test()
        {
            int[] unsorted = DataManager.GetUnsortedData();
            int[] sorted = DataManager.GetSortedData();

            _2._1._19.ShellSort sort = new _2._1._19.ShellSort();
            sort.Sort(unsorted);
            for (int i = 0; i < unsorted.Length; i++)
            {
                Assert.AreEqual(unsorted[i], sorted[i]);
            }
        }

        [TestMethod]
        public void ShellSort29Test()
        {
            int[] unsorted = DataManager.GetUnsortedData();
            int[] sorted = DataManager.GetSortedData();

            // ShellSort that use h = 3^n / 2
            _2._1._29.ShellSort sort = new _2._1._29.ShellSort();
            sort.Sort(unsorted);
            for (int i = 0; i < unsorted.Length; i++)
            {
                Assert.AreEqual(unsorted[i], sorted[i]);
            }

            // ShellSort that use offered h sequence
            unsorted = DataManager.GetUnsortedData();

            int n = unsorted.Length;
            int[] h = new int[2];   // 预先准备好的 h 值数组

            int hTemp = 1;
            for (int i = 0; hTemp < n; i++)
            {
                if (i >= h.Length)  // 如果数组不够大则双倍扩容
                {
                    int[] expand = new int[h.Length * 2];
                    for (int j = 0; j < h.Length; j++)
                    {
                        expand[j] = h[j];
                    }
                    h = expand;
                }
                h[i] = hTemp;
                hTemp = hTemp * 3 + 1;
            }

            sort.Sort(unsorted, h);
            for (int i = 0; i < unsorted.Length; i++)
            {
                Assert.AreEqual(unsorted[i], sorted[i]);
            }
        }

        [TestMethod]
        public void ShellSort30Test()
        {
            int[] unsorted = DataManager.GetUnsortedData();
            int[] sorted = DataManager.GetSortedData();

            // Normal shell sort
            _2._1._30.ShellSort sort = new _2._1._30.ShellSort();
            sort.Sort(unsorted);
            for (int i = 0; i < unsorted.Length; i++)
            {
                Assert.AreEqual(unsorted[i], sorted[i]);
            }

            // Shell sort that use geometric progression
            unsorted = DataManager.GetUnsortedData();
            sort.Sort(unsorted, 2);
            for (int i = 0; i < unsorted.Length; i++)
            {
                Assert.AreEqual(unsorted[i], sorted[i]);
            }
        }

        [TestMethod]
        public void SelectionSort16Test()
        {
            int[] unsorted = DataManager.GetUnsortedData();
            int testSize = 1000;
            string[] unsortedString = new string[testSize];
            string[] sortedString = new string[testSize];

            for (int i = 0; i < testSize; i++)
            {
                unsortedString[i] = unsorted[i].ToString();
                sortedString[i] = unsorted[i].ToString();
            }

            Array.Sort(sortedString);
            _2._1._16.Program.SelectionSort(unsortedString);

            for (int i = 0; i < testSize; i++)
            {
                Assert.AreEqual(unsortedString[i], sortedString[i]);
            }
        }

        [TestMethod]
        public void InsertionSort24Test()
        {
            int[] unsorted = DataManager.GetUnsortedData();
            int[] sorted = DataManager.GetSortedData();

            _2._1._24.InsertionSort sort = new _2._1._24.InsertionSort();
            sort.Sort(unsorted);
            for (int i = 0; i < unsorted.Length; i++)
            {
                Assert.AreEqual(unsorted[i], sorted[i]);
            }
        }

        [TestMethod]
        public void InsertionSort25Test()
        {
            int[] unsorted = DataManager.GetUnsortedData();
            int[] sorted = DataManager.GetSortedData();

            _2._1._25.InsertionSort sort = new _2._1._25.InsertionSort();
            sort.Sort(unsorted);
            for (int i = 0; i < unsorted.Length; i++)
            {
                Assert.AreEqual(unsorted[i], sorted[i]);
            }
        }

        [TestMethod]
        public void InsertionSort26Test()
        {
            int[] unsorted = DataManager.GetUnsortedData();
            int[] sorted = DataManager.GetSortedData();

            _2._1._26.InsertionSort sort = new _2._1._26.InsertionSort();
            sort.Sort(unsorted);
            for (int i = 0; i < unsorted.Length; i++)
            {
                Assert.AreEqual(unsorted[i], sorted[i]);
            }
        }
    }
}
