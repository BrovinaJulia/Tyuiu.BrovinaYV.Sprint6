using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.BrovinaYV.Sprint6.Task7.V27.Lib;

namespace Tyuiu.BrovinaYV.Sprint6.Task7.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            string path = @"C:\Users\broth\source\repos\Tyuiu.BrovinaYV.Sprint6\Tyuiu.BrovinaYV.Sprint6.Task7.V27\bin\Debug\InPutFileTask7V27.csv";
            int[,] matrix = dataService.GetMatrix(path);
            int[,] wait = { {-6,11,3,20,-10,20,-15,5,-19,-3},
                            {-8, 7,10,20,-18, -16, -3 , 15,  20,  20},
                            {13, 6, 1,2,-20, -17, -9,  -18, -5,  6},
                            {-13, 10 , 1,   -9,  -1,  -9,  -20, 15,  -7,  12},
                            {-1,15,  18,  6,   -1, 0  , 5,   16,  -1,  15 },
                            {14, -3,  8,   -1,  0,   -8,  -11 ,-3  ,4,4},
                            {13,-12,-1,-13,-1,17,19,12,14,15},
                            {2,-3,1,11,-7,-4,-15,-11,3,3},
                            {-13,11,8,-13,-17,-15,-18,0,-3,20},
                            {-11,-15,8,13,-3,14,18,-6,-14,-1} };
            CollectionAssert.AreEqual(wait, matrix);
            
        }
    }
}
