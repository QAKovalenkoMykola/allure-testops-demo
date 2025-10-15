using NUnit.Allure.Attributes;
using NUnit.Framework;

namespace AllureTestOpsDemo
{
    [TestFixture]
    public class SimpleTest
    {
        [Test(Description = "Check successful login")]
        [AllureTag("smoke")]
        [AllureOwner("Mykola")]
        public void TestAssertTrue()
        {
            Assert.That(true, Is.True);
        }
    }
}