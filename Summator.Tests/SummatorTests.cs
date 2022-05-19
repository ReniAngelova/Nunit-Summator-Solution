using NUnit.Framework;

namespace Summator.Tests
{
    public class Tests
    {
        [Test]
        public void Test_Sum_TwoPossitiveNumbers()
        {
            long actual = Summator.Sum(new int[] { 5, 7 });
            int expected = 12;

            Assert.That(expected == actual);
        }

        [Test]
        public void Test_Sum_OnePossitiveNumber()
        {
            long actual = Summator.Sum(new int[] { 5 });

            Assert.That(actual == 5);
        }

        [Test]
        public void Test_Sum_TwoNegativeNumbers()
        {
            long actual = Summator.Sum(new int[] { -7, -9 });

            Assert.That(actual == -16);
        }

        [Test]
        public void Test_Sum_EmtyArray()
        {
            long actual = Summator.Sum(new int[] { });

            Assert.That(actual == 0);
        }
        [Test]
        public void Test_Sum_BigValue()
        {
            long actual = Summator.Sum(new int[] { 2000000000, 2000000000, 2000000000, });

            Assert.AreEqual(8000000000, actual);
        }
        [Test]
        public void Test_Sum_TwoPositiveNumbers()
        {
            int actual = Summator.Average(new int[] { 5, 7 });
            int expected = 6;

            Assert.That(expected == actual);
        }
    }
}