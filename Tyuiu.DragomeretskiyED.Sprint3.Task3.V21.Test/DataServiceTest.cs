using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.DragomeretskiyED.Sprint3.Task3.V21.Lib;

namespace Tyuiu.DragomeretskiyED.Sprint3.Task3.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string str = "f3g5ht g4j 34kg4";
            char item = 'e';
            str = ds.ReplaceNumOnChar(str, item);
            string wait = "fegeht gej eekge";

            Assert.AreEqual(wait, str);
        }
    }
}
