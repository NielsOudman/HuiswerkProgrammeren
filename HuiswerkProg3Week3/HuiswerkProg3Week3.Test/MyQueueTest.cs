using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace HuiswerkProg3Week3.Test
{
    [TestClass]
    public class MyQueueTest
    {
        [TestMethod]
        public void MyQueue_CreateIsEmpty()
        {
            bool expected = true;
            bool actual;
            MyQueue<int> queue = new MyQueue<int>();

            actual = queue.IsEmpty();

            Assert.AreEqual(expected, actual);
        }
    }
}
