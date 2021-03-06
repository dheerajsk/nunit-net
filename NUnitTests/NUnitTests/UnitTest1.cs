using NUnit.Framework;

namespace NUnitTests
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            int num = 20;
            Assert.True(num == 20);
            Assert.Pass();
        }

        [Test]
        public void NewTest()
        {
            int total = 100, marks = 60, marks2 = 75;

            Assert.That(marks, Is.Not.EqualTo(marks2));
            Assert.That(marks, Is.LessThan(marks2));
            Assert.That(marks, Is.InRange(50, 80));
        }

        [Test]
        public void Warnings()
        {
            int total = 100, marks = 160, marks2 = 75;
            Warn.If(marks > 100);
            Warn.Unless(marks + marks2 < 200);
            Assert.Warn("This is a test warning message");
        }

    }
}