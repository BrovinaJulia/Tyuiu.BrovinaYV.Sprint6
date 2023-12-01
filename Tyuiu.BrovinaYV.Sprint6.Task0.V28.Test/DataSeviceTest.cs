using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BrovinaYV.Sprint6.Task0.V28.Lib;

namespace Tyuiu.BrovinaYV.Sprint6.Task0.V28.Test
{
    [TestClass]
    public class DataSeviceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            Assert.AreEqual(ds.Calculate(3), 169.89);

        }
    }
}
