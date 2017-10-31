using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestApp;
using NameSorterTest.TestUtils;

namespace NameSorterTest.Tests
{
    [TestClass]
    public class PersonTest
    {
        private Person person;
        private String fullName;
    
        /**
         *
         */
        [TestInitialize]
        public void Initialize() {
            fullName = new MockData().SingleNameData();
            person = new Person(fullName);
        }
    
        /**
         * Test of getName method, of class Person.
         */
        [TestMethod]
        public void TestGetName() {
            var name = person.Name;
            Assert.IsNotNull(person);
            Assert.IsNotNull(name);
            Assert.AreEqual(name.ToString(), fullName);
        }
    }
}
