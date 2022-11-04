// Lab_05_5_UT.cs
// Якубовський Владислав
// Unit-тест до програми Lab_05_5.cs
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AP_Lab_05_5;

namespace AP_Lab_05_5_UT
{
    [TestClass]
    public class Lab_05_5_UT
    {
        [TestMethod]
        public void TestF()
        {
            int depth = 0;

            double k = Lab_05_5.F(20, 8, 5, 0, 0, ref depth);

            Assert.AreEqual(6, k);
        }
    }
}
