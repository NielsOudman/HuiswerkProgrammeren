using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace HuiswerkProg3Week3.Test
{
    [TestClass]
    public class MyListTest
    {
        [TestMethod]
        public void MyList_Create()
        {
            int expected = 42;
            int actual;
            MyList<int> list = new MyList<int>(42);
            actual = list.ItemAt(0);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MyList_ItemAt_OutOfRange()
        {
            MyList<int> list = new MyList<int>(42);
            try
            {
                list.ItemAt(42);
                Assert.Fail("No error thrown");
            }
            catch (IndexOutOfRangeException e)
            {
                //no code needed
            }
            catch (Exception e)
            {
                Assert.Fail("IndexOutOfRangeException expected but " + e.GetType() + " received.");
            }
        }
    }
}