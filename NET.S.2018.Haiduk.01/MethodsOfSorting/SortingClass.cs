namespace MethodsOfSorting
{
    /// <summary>
    /// Class that contains methods of Quick Sorting and Merge Sorting of integer arrays
    /// </summary>
    public class SortingClass
    {
        /// <summary>
        /// This method divides unsorted array in half and sends them to sorting method
        /// </summary>
        /// <param name="arr">initial unsorted array</param>
        /// <returns>sorted by merging array</returns>
        public static int[] MergeSorting(int[] arr)
        {
            if (arr.Length == 1)
            {
                return arr;
            }

            int arrCenter = arr.Length / 2;
            int[] arr1 = new int[arrCenter];
            int[] arr2 = new int[arr.Length - arrCenter];
            for (int i = 0; i < arrCenter; i++)
            {
                arr1[i] = arr[i];
            }

            for (int i = arrCenter; i < arr.Length; i++)
            {
                arr2[i - arrCenter] = arr[i];
            }

            return Merging(MergeSorting(arr1), MergeSorting(arr2));
        }

        /// <summary>
        /// This method sorts 2 accepted arrays by merging
        /// </summary>
        /// <param name="arr1">1st accepted array</param>
        /// <param name="arr2">2nd accepted array</param>
        /// <returns>sorted by merging array</returns>
        public static int[] Merging(int[] arr1, int[] arr2)
        {
            int a = 0, b = 0;
            int[] merged = new int[arr1.Length + arr2.Length];
            for (int i = 0; i < arr1.Length + arr2.Length; i++)
            {
                if (b < arr2.Length && a < arr1.Length)
                {
                    if (arr1[a] > arr2[b])
                    {
                        merged[i] = arr2[b++];
                    }
                    else
                    {
                        merged[i] = arr1[a++];
                    }
                }
                else
                  if (b < arr2.Length)
                {
                    merged[i] = arr2[b++];
                }
                else
                {
                    merged[i] = arr1[a++];
                }
            }

            return merged;
        }

        /// <summary>
        /// This method sorts accepted array by Quick sorting
        /// </summary>
        /// <param name="arr">initial unsorted array</param>
        /// <param name="start">index of first element of accepted array</param>
        /// <param name="end">index of last element of accepted array</param>
        /// <returns>sorted array by Quick sorting</returns>
        public static int[] QuickSorting(int[] arr, int start, int end)
        {
            if (arr.Length == 1)
            {
                return arr;
            }
            
            int p = arr[((end - start) / 2) + start];
            int i = start, j = end;
            while (i <= j)
            {
                while (arr[i] < p && i <= end)
                {
                    ++i;
                }

                while (arr[j] > p && j >= start)
                {
                    --j;
                }

                if (i <= j)
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    ++i;
                    --j;
                }
            }

            if (j > start)
            {
                QuickSorting(arr, start, j);
            }

            if (i < end)
            {
                QuickSorting(arr, i, end);
            }

            return arr;
        }
    }
}
