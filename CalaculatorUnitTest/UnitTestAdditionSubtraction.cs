using ISimpleCalculatorClassLibrary;
namespace CalaculatorUnitTest
{
    [TestClass]
    public class UnitTestAdditionSubtraction
    {
        [TestMethod]
        public void TestAddition()
        {
            ImplementISimpleCalculator TestAdd = new ImplementISimpleCalculator();
            int Sum = TestAdd.Add(2, 2);
            Assert.AreEqual(Sum, 4);
        }

        [TestMethod]
        public void TestSubtraction()
        {
            ImplementISimpleCalculator TestSub = new ImplementISimpleCalculator();
            int Difference = TestSub.Subtract(4, 2);
            Assert.AreEqual(Difference, 2);
        }
    }
}