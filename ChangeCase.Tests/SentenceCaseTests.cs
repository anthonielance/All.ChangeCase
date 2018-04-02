using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Globalization;

namespace All.ChangeCase.Tests
{
    [TestClass]
    public class SentenceCaseTests
    {
        [TestMethod]
        public void NullInputTest()
        {
            TestSentenceCase(null, "");
        }

        [TestMethod]
        public void NumberInputTest()
        {
            TestSentenceCase("10", "10");
        }

        [TestMethod]
        public void SingleWordTest()
        {
            TestSentenceCase("test", "test");
            TestSentenceCase("TEST", "test");
        }

        [TestMethod]
        public void CamelCaseTest()
        {
            TestSentenceCase("testString", "test string");
            TestSentenceCase("testString123", "test string 123");
        }

        [TestMethod]
        public void NonAlphaNumericSeparatorsTest()
        {
            TestSentenceCase("dot.case", "dot case");
            TestSentenceCase("path/case", "path case");
            TestSentenceCase("snake_case", "snake case");
        }

        [TestMethod]
        public void PunctuationTest()
        {
            TestSentenceCase("\"quotes\"", "quotes");
        }

        [TestMethod]
        public void SpaceBetweenNumberPartsTest()
        {
            TestSentenceCase("version 1.2.10", "version 1 2 10");
            TestSentenceCase("version 0.45.0", "version 0 45 0");
            TestSentenceCase("version 0..78..9", "version 0 78 9");
            TestSentenceCase("version 4_99/4", "version 4 99 4");
        }


        [TestMethod]
        public void WhitespaceTest()
        {
            TestSentenceCase("  test  ", "test");
        }

        [TestMethod]
        public void NonAsciiChacterTest()
        {
            // Non-ascii characters.
            TestSentenceCase("español", "español");
            TestSentenceCase("Beyoncé Knowles", "beyoncé knowles");
            TestSentenceCase("Iñtërnâtiônàlizætiøn", "iñtërnâtiônàlizætiøn");
        }

        [TestMethod]
        public void NumberStringInput()
        {
            // Number string input.
            TestSentenceCase("something2014other", "something 2014 other");
        }

        [TestMethod]
        public void CustomReplacementTest()
        {
            // Custom replacement character
            TestSentenceCase("HELLO WORLD!", "hello_world", "_");
        }

        [TestMethod]
        public void CustomLocaletest()
        {
            string actual = "A STRING".SentenceCase(" ", CultureInfo.CreateSpecificCulture("tr"));
            Assert.AreEqual("a strıng", actual);
        }


        private static void TestSentenceCase(string input, string expected)
        {
            string actual = input.SentenceCase();
            Assert.AreEqual(expected, actual);
        }

        private static void TestSentenceCase(string input, string expected, string replacement)
        {
            string actual = input.SentenceCase(replacement);
            Assert.AreEqual(expected, actual);
        }
    }
}
