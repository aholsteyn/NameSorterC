using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestApp;
using System.Linq;
using NameSorterTest.TestUtils;

namespace NameSorterTest.Tests
{
    [TestClass]
    public class PersonComparatorTest
    {
        private PersonComparator comparator;
    
        /**
         *
         */
        [TestInitialize]
        public void Initialize() {
            comparator = new PersonComparator();
        }

        /**
         * Test of sort method, of class GenericListSort.
         */
        [TestMethod]
        public void TestSort() {
            var unorderedList = new MockData().ExpectedUnorderedList();
            var expResult = TestUtils.TestUtils.ConvertPersonListToNameList(new MockData().ExpectedOrderedList()).ToList();
            var result = TestUtils.TestUtils.ConvertPersonListToNameList(comparator.OrderList(unorderedList)).ToList();
            Assert.AreNotEqual(result.Count, 0);
            Assert.AreEqual(result.Count, 14);
            Assert.AreEqual(result.Count, expResult.Count);
            CollectionAssert.AreEqual(result, expResult);
        }
    }
}
