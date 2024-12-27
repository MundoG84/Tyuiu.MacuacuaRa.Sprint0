using Tyuiu.MacuacuaRa.Sprint0.Task2.V0.Lib;

namespace Tyuiu.MacuacuaRa.Sprint0.Task2.V0.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var name = "Macuacua";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("привет, Macuacua", res);
        }
    }
}