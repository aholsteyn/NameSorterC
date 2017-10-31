using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestApp;
using NameSorterTest.TestUtils;
using System.IO;

namespace NameSorterTest.Tests
{
    [TestClass]
    public class NameWriterTest
    {
        /**
         * Test of Write method, of class NameFileWriter.
         * Tests if file is created and if contents match the expected sorted names
         */
        [TestMethod]
        public void TestWrite() {
            var resultFileName = "sorted-names-list-test.txt";
            var originalFileName = "sorted-names-list.txt";
            var persons = new MockData().ExpectedOrderedList();
            string s1, s2;
            new NameWriter().WriteNames(persons, resultFileName);
            s1 = System.Text.Encoding.UTF8.GetString(File.ReadAllBytes(originalFileName));
            s2 = System.Text.Encoding.UTF8.GetString(File.ReadAllBytes(resultFileName));
            Assert.IsTrue(File.Exists(resultFileName));
            Assert.AreEqual(s1, s2);
        }
    
        /**
         * Test of FileWriter method, of class NameFileWriter.
         * Tests invalid file name. Throws IOException when trying to write to directory
         */
        [TestMethod]
        [ExpectedException(typeof(IOException))]
        public void TestFileWriterWithWrongFileName(){
            new NameWriter().WriteNames(new MockData().ExpectedOrderedList(), "test/");
        }
    }
}
