using Microsoft.VisualStudio.TestTools.UnitTesting;
using EssentialTraining;

namespace EssentialTrainingTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var testInstance = new Class1();
            var testresult = testInstance.AddTwo(9, 5);
            Assert.AreEqual(14, testresult, "expected result is 14");
        }
    }
}
