using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MethodsOfSorting.Tests
{
    #region MergeSortTests

    [TestClass]
    public class SortingClassTests
    {
        [TestMethod]
        public void MergeSortingTest_AcceptsNullArray_ThrowsNullReferenceException()
        {
            int[] unsorted = null;
            Assert.ThrowsException<NullReferenceException>(() => SortingClass.MergeSorting(unsorted));
        }

        [TestMethod]
        public void MergeSortingTest_AcceptsEmptyArray_ThrowsArgumentException()
        {
            int[] unsorted = new int[0];
            Assert.ThrowsException<ArgumentException>(() => SortingClass.MergeSorting(unsorted));
        }

        [TestMethod]
        public void MergeSortingTest1()
        {
            // Arrange
            int[] unsorted = { 1, -5, 0, 15, -4, 27 };

            // Act
            int[] sortedByMergeSort = SortingClass.MergeSorting(unsorted);

            // Assert
            CollectionAssert.AreEqual(new int[] { -5, -4, 0, 1, 15, 27 }, sortedByMergeSort);
        }

        [TestMethod]
        public void MergeSortingTest2()
        {
            // Arrange
            int[] unsorted = { 1 };

            // Act
            int[] sortedByMergeSort = SortingClass.MergeSorting(unsorted);

            // Assert
            CollectionAssert.AreEqual(new int[] { 1 }, sortedByMergeSort);
        }

        [TestMethod]
        public void MergeSortingTest3()
        {
            // Arrange
            int[] unsorted = new int[100];
            Random random = new Random();
            for (int i = 0; i < unsorted.Length; ++i)
            {
                unsorted[i] = random.Next(int.MinValue, int.MaxValue);
            }

            // Act
            int[] sortedByMergeSort = SortingClass.MergeSorting(unsorted);

            // Assert
            Assert.IsTrue(IsArraySorted(sortedByMergeSort));
        }
        #endregion

        #region QuickSortTests

        [TestMethod]
        public void QuickSortingTest1()
        {
            // Arrange
            int[] unsorted1 = { 1, -5, 0, 15, -4, 27 };
            int[] unsorted2 = { 1, -5, 0, 15, -4, 27 };

            // Act
            Array.Sort(unsorted2);
            SortingClass.QuickSorting(unsorted1, 0, unsorted1.Length - 1);
            
            // Assert
            CollectionAssert.AreEqual(unsorted2, unsorted1);
        }

        [TestMethod]
        public void QuickSortingTest2()
        {
            // Arrange
            int[] unsorted = new int[100];
            Random random = new Random();
            for (int i = 0; i < unsorted.Length; ++i)
            {
                unsorted[i] = random.Next(1, 10);
            }

            // Act
            SortingClass.QuickSorting(unsorted, 0, unsorted.Length - 1);

            // Assert
            Assert.IsTrue(IsArraySorted(unsorted));                   
        }

        [TestMethod]
        public void QuickSortingTest3()
        {
            // Arrange
            int[] unsorted = new int[100];
            Random random = new Random();
            for (int i = 0; i < unsorted.Length; ++i)
            {
                unsorted[i] = random.Next(int.MinValue, int.MaxValue);
            }

            // Act
            SortingClass.QuickSorting(unsorted, 0, unsorted.Length - 1);

            // Assert
            Assert.IsTrue(IsArraySorted(unsorted));
        }

        [TestMethod]        
        public void QuickSortingTest_AcceptsNullArray_ThrowsNullReferenceException()
        {            
            int[] unsorted = null;
            Assert.ThrowsException<NullReferenceException>(() => SortingClass.QuickSorting(unsorted, 0, unsorted.Length - 1));
        }

        [TestMethod]
        public void QuickSortingTest_AcceptsEmptyArray_ThrowsArgumentException()
        {
            int[] unsorted = new int[0];
            Assert.ThrowsException<ArgumentException>(() => SortingClass.QuickSorting(unsorted, 0, unsorted.Length - 1));
        }

        private static bool IsArraySorted(int[] array)
        {
            int a = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] <= array[i + 1])
                {
                    a++;
                }
            }

            if (a == array.Length - 1)
            {
                return true;
            }

            return false;
        }
        #endregion
    }
}
