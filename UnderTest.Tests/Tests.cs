using System;
using NUnit.Framework;

namespace UnderTest.Tests
{
    public class Tests
    {
        [Test]
        public void Diff_Test()
        {
            DateTime now = DateTime.Now;
            TimeSpan diff = TimeSpan.FromDays(5);
            TimeSpan actual = new DateTimeCalculator().Diff(now, now - diff);
        }

        [Test]
        public void IsDefault_ShouldReturnTrue_WhenDefault()
        {
            Assert.IsTrue(new DateTimeCalculator().IsDefault(default));
        }
        
        [Test]
        public void IsDefault_ShouldReturnTrue_WhenNotDefault()
        {
            Assert.IsFalse(new DateTimeCalculator().IsDefault(DateTime.Now));
        }
    }
}