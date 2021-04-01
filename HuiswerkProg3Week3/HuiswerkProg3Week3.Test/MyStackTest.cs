using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace HuiswerkProg3Week3.Test
{
    [TestClass]
    public class MyStackTest
    {
        [TestMethod]
        public void MyStack_CreateIsEmpty()
        {
            bool expected = true;
            bool actual;
            MyStack<int> stack = new MyStack<int>();

            actual = stack.IsEmpty();

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void MyStack_CreateWithOneIsNotEmpty()
        {
            bool expected = false;
            bool actual;
            MyStack<int> stack = new MyStack<int>();

            stack.Push(42);
            actual = stack.IsEmpty();

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void MyStack_PeekEmpty()
        {
            MyStack<int> stack = new MyStack<int>();
            try
            {
                stack.Peek();
                Assert.Fail("InvalidOperationException expected but no exception received.");
            }
            catch (InvalidOperationException) { }
            catch (Exception e)
            {
                Assert.Fail("InvalidOperationException expected but " + e.GetType() + " received.");
            }
        }
        [TestMethod]
        public void MyStack_PeekStrings()
        {
            const string third = "third";
            string expected = third;
            string actual;
            MyStack<string> stack = new MyStack<string>();

            stack.Push("first");
            stack.Push("second");
            stack.Push(third);
            actual = stack.Peek();
            Assert.AreEqual(expected, actual);
            actual = stack.Peek();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MyStack_PopEmpty()
        {
            MyStack<int> stack = new MyStack<int>();
            try
            {
                stack.Pop();
                Assert.Fail("InvalidOperationException expected but no exception received.");
            }
            catch (InvalidOperationException) { }
            catch (Exception e)
            {
                Assert.Fail("InvalidOperationException expected but " + e.GetType() + " received.");
            }
        }
        [TestMethod]
        public void MyStack_PopStrings()
        {
            const string second = "second";
            const string third = "third";
            string actual;
            MyStack<string> stack = new MyStack<string>();
            stack.Push("first");
            stack.Push(second);
            stack.Push(third);

            string expected = third;
            actual = stack.Pop();
            Assert.AreEqual(expected, actual);

            expected = second;
            actual = stack.Pop();
            Assert.AreEqual(expected, actual);

            stack.Pop();
            bool empty = stack.IsEmpty();
            Assert.AreEqual(true, empty);
        }

    }
}
