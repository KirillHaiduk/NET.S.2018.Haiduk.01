using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MethodsOfSorting.Tests
{
    [TestClass]
    public class SortingClassTests
    {
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
        public void QuickSortingTest1()
        {
            // Arrange
            int[] unsorted = { 1, -5, 0, 15, -4, 27 };

            // Act
            int[] sortedByQuickSort = SortingClass.QuickSorting(unsorted, 0, unsorted.Length - 1);

            // Assert
            CollectionAssert.AreEqual(new int[] { -5, -4, 0, 1, 15, 27 }, sortedByQuickSort);
        }

        [TestMethod]
        public void QuickSortingTest2()
        {
            // Arrange
            int[] unsorted = { 0 };

            // Act
            int[] sortedByQuickSort = SortingClass.QuickSorting(unsorted, 0, unsorted.Length - 1);

            // Assert
            CollectionAssert.AreEqual(new int[] { 0 }, sortedByQuickSort);
        }
    }
}