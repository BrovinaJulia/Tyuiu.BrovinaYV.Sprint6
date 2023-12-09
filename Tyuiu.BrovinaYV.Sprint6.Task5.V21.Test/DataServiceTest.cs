﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.BrovinaYV.Sprint6.Task5.V21.Lib;

namespace Tyuiu.BrovinaYV.Sprint6.Task5.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\broth\source\repos\Tyuiu.BrovinaYV.Sprint6\Tyuiu.BrovinaYV.Sprint6.Task5.V21\bin\Debug\InPutFileTask5V21.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
