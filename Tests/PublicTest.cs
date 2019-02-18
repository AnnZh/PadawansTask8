using NUnit.Framework;

namespace PadawansTask8.Tests
{
    [TestFixture]
    public class PublicTest
    {
        [Test]
        public void RemoveDuplicateWordsTest()
        {
            string actual = "alpha beta1 beta1 gamma gamma gamma delta alpha beta beta gamma gamma gamma delta";

            string expected = "alpha beta1 1 gamma   delta       ";

            WordsManipulation.RemoveDuplicateWords(ref actual);

            Assert.AreEqual(expected, actual);
        }
    }
}