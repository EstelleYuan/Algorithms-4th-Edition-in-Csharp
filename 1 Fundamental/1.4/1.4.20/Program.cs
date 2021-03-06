﻿using System;

namespace _1._4._20
{
    /*
     * 1.4.20
     * 
     * 双调查找。
     * 如果一个数组中的所有元素是先递增后递减的，则称这个数组为双调的。
     * 编写一个程序，给定一个含有 N 个不同 int 值的双调数组，判断它是否含有给定的整数。
     * 程序在最坏情况下所需的比较次数为 ~3lgN
     * 
     */
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = BitonicMax.Bitonic(100);
            int max = BitonicMax.Max(a, 0, a.Length - 1);
            int key = a[50];
            int leftside = BinarySearchAscending(a, key, 0, max);
            int rightside = BinarySearchDescending(a, key, max, a.Length - 1);

            if (leftside != -1)
            {
                Console.WriteLine(leftside);
            }
            else if (rightside != -1)
            {
                Console.WriteLine(rightside);
            }
            else
            {
                Console.WriteLine("No Result");
            }
        }

        /// <summary>
        /// 对升序数组的二分查找。
        /// </summary>
        /// <param name="a">升序数组。</param>
        /// <param name="key">关键值。</param>
        /// <param name="lo">查找的左边界。</param>
        /// <param name="hi">查找的右边界。</param>
        /// <returns>返回找到关键值的下标，如果没有找到则返回 -1。</returns>
        static int BinarySearchAscending(int[] a, int key, int lo, int hi)
        {
            while (lo <= hi)
            {
                int mid = lo + (hi - lo) / 2;

                if (a[mid] < key)
                {
                    lo = mid + 1;
                }
                else if (a[mid] > key)
                {
                    hi = mid - 1;
                }
                else
                {
                    return mid;
                }
            }

            return -1;
        }

        /// <summary>
        /// 对降序数组的二分查找。
        /// </summary>
        /// <param name="a">升序数组。</param>
        /// <param name="key">关键值。</param>
        /// <param name="lo">查找的左边界。</param>
        /// <param name="hi">查找的右边界。</param>
        /// <returns>返回找到关键值的下标，如果没有找到则返回 -1。</returns>
        static int BinarySearchDescending(int[] a, int key, int lo, int hi)
        {
            while (lo < hi)
            {
                int mid = lo + (hi - lo) / 2;

                if (a[mid] > key)
                {
                    lo = mid + 1;
                }
                else if (a[mid] < key)
                {
                    hi = mid - 1;
                }
                else
                {
                    return mid;
                }
            }

            return -1;
        }
    }
}
