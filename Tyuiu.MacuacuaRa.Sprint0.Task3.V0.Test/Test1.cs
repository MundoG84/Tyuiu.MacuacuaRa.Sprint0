﻿using Tyuiu.MacuacuaRa.Sprint0.Task3.V0.Lib;

namespace Tyuiu.MacuacuaRa.Sprint0.Task3.V0.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void CheckedValid()
        {
            Assert.AreEqual(10, DataService.Sum(5, 5));
        }
    }
}