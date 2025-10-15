using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;

namespace AllureTestOpsDemo
{
    [AllureNUnit]
    public class SimpleTest
    {
        [AllureTag("smoke")]
        [AllureOwner("Mykola")]
        [Test(Description = "Check successful login")]
        public void TestAssertTrue()
        {
            Assert.That(true, Is.True);
        }
    }
}