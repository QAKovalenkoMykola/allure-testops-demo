using NUnit.Framework;

namespace AllureTestOpsDemo
{
    [TestFixture]
    public class SimpleTest
    {
        [Test]
        public void TestAssertTrue()
        {
            Assert.That(true, Is.True);
        }
    }
}