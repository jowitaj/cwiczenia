using egzamin.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace x1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            object a = new PriorityTask("Task 1", 1);
            object b = new PriorityTask("Task 1", 1);
            object c = new DescribedTask("Task 2", 2, "Description 2");

            Assert.AreEqual(a, a);
            Assert.AreEqual(a, b);
            Assert.AreNotEqual(c, a);
        }
    }
}
