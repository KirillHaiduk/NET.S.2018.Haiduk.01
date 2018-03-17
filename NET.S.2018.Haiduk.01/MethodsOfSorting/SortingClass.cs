using System;

namespace MethodsOfSorting
{
    /// <summary>
    /// Class that contains methods of Quick Sorting and Merge Sorting of integer arrays
    /// </summary>
    public class SortingClass
    {
        #region Public methods
        /// <summary>
        /// This method sorts accepted array by Quick sorting
        /// </summary>
        /// <param name="array">initial unsorted array</param>
        /// <param name="start">index of first element of accepted array</param>
        /// <param name="end">index of last element of accepted array</param>
        /// <returns>sorted array by Quick sorting</returns>
        public static void QuickSorting(int[] array, int start, int end)
        {
            if (array.Length == 0)
            {
                throw new ArgumentException($"{nameof(array)} length is 0.");
            }

            if (array == null)
            {
                throw new NullReferenceException($"{nameof(array)} is null.");
            }

            if (array.Length == 1)
            {
                return;
            }

            int center = array[((end - start) / 2) + start];
            int i = start, j = end;
            while (i <= j)
            {
                while (array[i] < center && i <= end)
                {
                    ++i;
                }

                while (array[j] > center && j >= start)
                {
                    --j;
                }

                if (i <= j)
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    ++i;
                    --j;
                }
            }

            if (j > start)
            {
                QuickSorting(array, start, j);
            }

            if (i < end)
            {
                QuickSorting(array, i, end);
            }
        }

        /// <summary>
        /// This method divides unsorted array in half and sends them to sorting method
        /// </summary>
        /// <param name="array">initial unsorted array</param>
        /// <returns>sorted by merging array</returns>
        public static int[] MergeSorting(int[] array)
        {
            if (array.Length == 0)
            {
                throw new ArgumentException($"{nameof(array)} length is 0.");
            }

            if (array == null)
            {
                throw new NullReferenceException($"{nameof(array)} is null.");
            }

            if (array.Length == 1)
            {
                return array;
            }

            int arrCenter = array.Length / 2;
            int[] arr1 = new int[arrCenter];
            int[] arr2 = new int[array.Length - arrCenter];
            for (int i = 0; i < arrCenter; i++)
            {
                arr1[i] = array[i];
            }

            for (int i = arrCenter; i < array.Length; i++)
            {
                arr2[i - arrCenter] = array[i];
            }

            return Merging(MergeSorting(arr1), MergeSorting(arr2));
        }

        #endregion

        #region Private methods
        /// <summary>
        /// This method sorts 2 accepted arrays by merging
        /// </summary>
        /// <param name="array1">1st accepted array</param>
        /// <param name="array2">2nd accepted array</param>
        /// <returns>sorted by merging array</returns>
        private static int[] Merging(int[] array1, int[] array2)
        {
            int a = 0, b = 0;
            int[] merged = new int[array1.Length + array2.Length];
            for (int i = 0; i < array1.Length + array2.Length; i++)
            {
                if (b < array2.Length && a < array1.Length)
                {
                    if (array1[a] > array2[b])
                    {
                        merged[i] = array2[b++];
                    }
                    else
                    {
                        merged[i] = array1[a++];
                    }
                }
                else
                  if (b < array2.Length)
                {
                    merged[i] = array2[b++];
                }
                else
                {
                    merged[i] = array1[a++];
                }
            }

            return merged;
        }
        #endregion                
    }
}
