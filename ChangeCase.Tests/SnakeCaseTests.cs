using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Globalization;

namespace All.ChangeCase.Tests
{
    [TestClass]
    public class SnakeCaseTests
    {
        [TestMethod]
        public void RegularSentenceTest()
        {
            TestSnakeCase("test string", "test_string");
            TestSnakeCase("Test String", "test_string");
        }

        [TestMethod]
        public void NonAlphanumericSeparatorsTest()
        {
            TestSnakeCase("dot.case", "dot_case");
            TestSnakeCase("path/case", "path_case");
        }

        [TestMethod]
        public void MixStringsTest()
        {
            TestSnakeCase("TestString", "test_string");
            TestSnakeCase("TestString1_2_3", "test_string_1_2_3");
        }

        [TestMethod]
        public void NonLatinCharactersTest()
        {
            TestSnakeCase("'My Entrée", "my_entrée");
        }

        [TestMethod]
        public void LocaleSupportTest()
        {
            string actual = "MY STRING".SnakeCase(CultureInfo.CreateSpecificCulture("tr"));
            Assert.AreEqual("my_strıng", actual);
        }

        private void TestSnakeCase(string input, string expected)
        {
            var actual = input.SnakeCase();
            Assert.AreEqual(expected,actual);
        }
    }
}
