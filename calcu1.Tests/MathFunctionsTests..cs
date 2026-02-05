using Microsoft.VisualStudio.TestTools.UnitTesting;
using calcu1;

namespace calcu1.Tests
{
    [TestClass]
    public class MathFunctionsTests
    {
        [TestMethod]
        public void Add_2_3_Returns_5()
        {
            var mf = new MathFuctions();
            var result = mf.calc(2, 3, "Add");
            Assert.AreEqual(5, result, 1e-9);
        }

        [TestMethod]
        public void Div_10_2_Returns_5()
        {
            var mf = new MathFuctions();
            var result = mf.calc(10, 2, "Div");
            Assert.AreEqual(5, result, 1e-9);
        }

        [TestMethod]
        public void InvA_4_Returns_0_25()
        {
            var mf = new MathFuctions();
            var result = mf.calc(4, 0, "InvA");
            Assert.AreEqual(0.25, result, 1e-9);
        }

        [TestMethod]
        public void Sin_0_Returns_0()
        {
            var mf = new MathFuctions();
            var result = mf.calc(0, 0, "sin");
            Assert.AreEqual(0, result, 1e-9);
        }

        [TestMethod]
        public void Ctn_PiOver4_Returns_Approximately_1()
        {
            var mf = new MathFuctions();
            double piOver4 = 0.7853981633974483; // π/4 (радіани)
            var result = mf.calc(piOver4, 0, "ctn");
            Assert.AreEqual(1.0, result, 0.01);
        }
    }
}