using MaxOnesAfterRemoveItem;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestMethod()
        {
            Assert.IsTrue(ArrayFunctions.MaxOnesAfterRemoveItem(new byte[] { 0, 0 }) == 0);
            Assert.IsTrue(ArrayFunctions.MaxOnesAfterRemoveItem(new byte[] { 0, 1 }) == 1);
            Assert.IsTrue(ArrayFunctions.MaxOnesAfterRemoveItem(new byte[] { 1, 0 }) == 1);
            Assert.IsTrue(ArrayFunctions.MaxOnesAfterRemoveItem(new byte[] { 1, 1 }) == 1);
            Assert.IsTrue(ArrayFunctions.MaxOnesAfterRemoveItem(new byte[] { 1, 1, 0, 1, 1 }) == 4);
            Assert.IsTrue(ArrayFunctions.MaxOnesAfterRemoveItem(new byte[] { 1, 1, 0, 1, 1, 0, 1, 1, 1 }) == 5);
            Assert.IsTrue(ArrayFunctions.MaxOnesAfterRemoveItem(new byte[] { 1, 1, 0, 1, 1, 0, 1, 1, 1, 0 }) == 5);
        }
    }
}