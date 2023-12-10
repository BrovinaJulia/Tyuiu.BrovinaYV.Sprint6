using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.BrovinaYV.Sprint6.Task6.V23.Lib;

namespace Tyuiu.BrovinaYV.Sprint6.Task6.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var dataService = new DataService();
            var path = @"C:\Users\broth\source\repos\Tyuiu.BrovinaYV.Sprint6\Tyuiu.BrovinaYV.Sprint6.Task6.V23\bin\Debug\InPutFileTask6V23.txt";
            var result = dataService.CollectTextFromFile(path);

            Assert.AreEqual("iKDOjtfsPmw ", result);

        }
    }
}
