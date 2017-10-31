using Microsoft.VisualStudio.TestTools.UnitTesting;
using NameSorterTest.TestUtils;
using System;
using TestApp;

namespace NameSorterTest.Tests
{
    [TestClass]
    public class NameTest
    {

        private String fullName;
        private Name name;

        [TestInitialize]
        public void Initialize()
        {
            fullName = new MockData().SingleNameData();
            name = new Name (fullName);
        }
    
        /**
         * Test of getGivenNames method, of class Name.
         */
        [TestMethod]
        public void TestGetGivenNames() {
            Assert.IsNotNull(name);
            Assert.AreEqual(name.GivenNames, "Beau Tristan");
        }

        /**
         * Test of getLastName method, of class Name.
         */
        [TestMethod]
        public void TestGetLastName() {
            Assert.IsNotNull(name);
            Assert.AreEqual(name.LastName, "Bentley");
        }

        /**
         * Test of toString method, of class Name.
         */
        [TestMethod]
        public void TestToString()
        {
            Assert.IsNotNull(name);
            Assert.AreEqual(name.ToString(), fullName);
        }
    }
}
