using Microsoft.VisualStudio.TestTools.UnitTesting;
using NameSorterTest.TestUtils;
using System.IO;
using TestApp;

namespace NameSorterTest.Tests
{
    [TestClass]
    public class NameValidatorTest
    {
        private NameValidator nameValidator;

        /**
         *  Initialize a new name validator
         */
        [TestInitialize]
        public void Initialize()
        {
            nameValidator = new NameValidator();
        }

        /**
         * Test of validateName method, of class NameValidator.
         * Success case.
         */
        [TestMethod]
        public void TestValidateNameSuccess() {
            var fullName = new MockData().SingleNameData();
            nameValidator.Validate(fullName);
            var nameLength = fullName.Split(' ').Length;
            Assert.AreEqual(nameLength, 3);
        }

        /**
         * Test of validateName method, of class NameValidator.
         * Failure due to single word name. No given names.
         */
        [TestMethod]
        [ExpectedException(typeof(IOException))]
        public void TestValidateNameNoGivenNames()
        {
            var fullName = new MockData().NoGivenNamesData();
            nameValidator.Validate(fullName);
        }

        /**
         * Test of validateName method, of class NameValidator.
         * Failure due to excessive long name. More than 3 given names.
         */
        [TestMethod]
        [ExpectedException(typeof(IOException))]
        public void TestValidateNameExcessiveNames()
        {
            var fullName = new MockData().ExcessiveGivenNamesData();
            nameValidator.Validate(fullName);
        }
    }
}
