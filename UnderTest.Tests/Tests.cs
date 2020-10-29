using System;
using NUnit.Framework;

namespace UnderTest.Tests
{
    public class Tests
    {
        [Test]
        public void Test()
        {
            DateTime now = DateTime.Now;
            TimeSpan diff = TimeSpan.FromDays(5);
            TimeSpan actual = new DateTimeCalculator().Diff(now, now - diff);
            Assert.AreEqual(actual, diff);
        }
    }
}