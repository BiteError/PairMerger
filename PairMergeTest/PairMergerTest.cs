using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PairMerge;
using System.Collections.Generic;

namespace PairMergeTests
{
    [TestClass]
    public class PairMergerTest
    {
        [TestMethod]
        public void TestMethodForForwardMergeListWithNulls()
        {
            var inputList = new List<int>() { 0, 0, 0, 1, 0, 1 };
            var expected = new List<int>() { 2 };
            var actual = PairMerger.Merge(inputList);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethodForForwardMerge()
        {
            var inputList = new List<int>() { 1, 2, 1, 1, 2, 4, 16 };
            var expected = new List<int>() { 1, 2, 8, 16 };
            var actual = PairMerger.Merge(inputList);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethodForEmptyList()
        {
            var inputList = new List<int>();
            var expected = new List<int>();
            var actual = PairMerger.Merge(inputList);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethodForOneElementList1()
        {
            var inputList = new List<int>() { 0 };
            var expected = new List<int>();
            var actual = PairMerger.Merge(inputList);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethodForOneElementList2()
        {
            var inputList = new List<int>() { 1 };
            var expected = new List<int>() { 1 };
            var actual = PairMerger.Merge(inputList);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethodForListWithManyNulls()
        {
            var inputList = new List<int>() { 0, 0, 0, 0 };
            var expected = new List<int>();
            var actual = PairMerger.Merge(inputList);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethodForBackwardMerge()
        {
            var inputList = new List<int>() { 2, 1, 1 };
            var expected = new List<int>() { 4 };
            var actual = PairMerger.Merge(inputList);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethodForBackwardAndForwardMerge()
        {
            var inputList = new List<int>() { 2, 1, 1, 8 };
            var expected = new List<int>() { 4, 8 };
            var actual = PairMerger.Merge(inputList);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethodForManyBackwardsMerge()
        {
            var inputList = new List<int>() { 16, 4, 2, 1, 1, 8 };
            var expected = new List<int>() { 32 };
            var actual = PairMerger.Merge(inputList);

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}