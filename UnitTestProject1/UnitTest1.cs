using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class LinkedListTests
    {
        [TestMethod]
        public void TestHasAdjacentDuplicates()
        {
            LinkedList linkedList = new LinkedList();

            Assert.IsFalse(linkedList.HasAdjacentDuplicates(), "Empty list should not have adjacent duplicates.");

            linkedList.Append(1);
            linkedList.Append(2);
            linkedList.Append(2);

            Assert.IsTrue(linkedList.HasAdjacentDuplicates(), "List contains adjacent duplicates.");

            linkedList.Destroy();

            Assert.IsFalse(linkedList.HasAdjacentDuplicates(), "Destroyed list should not have adjacent duplicates.");
        }
    }
}
