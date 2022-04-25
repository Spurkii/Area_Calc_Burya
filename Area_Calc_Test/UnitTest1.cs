using Area_Calc_Burya;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Area_Calc_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IntSquareArea()
        {
            Assert.AreEqual(4, AreaCalculator.GetSquareArea(2));
        }
        [TestMethod]
        public void strSquareArea()
        {
            Assert.AreEqual(4, AreaCalculator.GetSquareArea("two"));
        }
        [TestMethod]
        [ExpectedException(typeof(System.Collections.Generic.KeyNotFoundException))]
        public void ErrStrSquareArea()
        {
            Assert.AreEqual(4, AreaCalculator.GetSquareArea("seckus"));
        }
        [TestMethod]
        public void RectangleArea()
        {
            Assert.AreEqual(20, AreaCalculator.GetRectangleArea(5, 4));
        }
        [TestMethod]
        public void TriangleArea()
        {
            Assert.AreEqual(10, AreaCalculator.GetTriangleArea(10, 2));
        }
        [TestMethod]
        public void ParallelogramArea()
        {
            Assert.AreEqual(12, AreaCalculator.GetParallelogramArea(3, 4));
        }
        [TestMethod]
        public void CircleRadius()
        {
            Assert.AreEqual(1, AreaCalculator.GetCircleRadius(2));
        }
        [TestMethod]
        public void CircleDIameter()
        {
            Assert.AreEqual(4, AreaCalculator.GetCircleDiameter(2));
        }
    }
}