using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Globalization;

namespace All.ChangeCase.Tests
{
    [TestClass]
    public class ConstantCaseTests
    {
        [TestMethod]
        public void RegularSentenceCaseTest()
        {
            TestConstantCase("test string", "TEST_STRING");
            TestConstantCase("Test String", "TEST_STRING");
        }

        [TestMethod]
        public void NonAlphanumericSeparatorsTest()
        {
            TestConstantCase("dot.case", "DOT_CASE");
            TestConstantCase("path/case", "PATH_CASE");
        }

        [TestMethod]
        public void MixStringsTest()
        {
            TestConstantCase("TestString", "TEST_STRING");
            TestConstantCase("TestString1_2_3", "TEST_STRING_1_2_3");
        }

        [TestMethod]
        public void NonLatinCharactersTest()
        {
            TestConstantCase("'My Entrée", "MY_ENTRÉE");
        }

        [TestMethod]
        public void LocaleSupportTest()
        {
            string actual = "myString".ConstantCase(CultureInfo.CreateSpecificCulture("tr"));
            Assert.AreEqual("MY_STRİNG", actual);
        }

        private void TestConstantCase(string input, string expected)
        {
            var actual = input.ConstantCase();
            Assert.AreEqual(expected, actual);
        }
    }
}
