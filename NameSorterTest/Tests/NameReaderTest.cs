using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using TestApp;
using NameSorterTest.TestUtils;
using System.Linq;

namespace NameSorterTest.Tests
{
    [TestClass]
    public class NameReaderTest
    {
        /**
         * Test of ProcessFile method, of class NameFileReader.
         * Tests for size, not empty, same size as expected result, same names as result
         */
        [TestMethod]
        public void TestProcessFile() {
            var instance = new NameReader("unsorted-names-list.txt");
            var expResult = TestUtils.TestUtils.ConvertPersonListToNameList(new MockData().ExpectedUnorderedList()).ToList();
            var result = TestUtils.TestUtils.ConvertPersonListToNameList(instance.Process()).ToList();
            Assert.AreNotEqual(result, 0);
            Assert.AreEqual(result.Count, 14);
            Assert.AreEqual(result.Count, expResult.Count);
            CollectionAssert.AreEqual(result, expResult);
        }
    
        /**
         * Test of ProcessFile method, of class NameFileReader.
         * Tests invalid file name
         */
        [TestMethod]
        [ExpectedException(typeof(FileNotFoundException))]
        public void TestProcessFileWithWrongFileName() {
            NameReader instance = new NameReader("WrongFileName.txt");
            instance.Process();
        }
    }
}
