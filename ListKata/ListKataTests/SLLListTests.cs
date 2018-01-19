using Microsoft.VisualStudio.TestTools.UnitTesting;
using ListKata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListKata.Tests
{
    [TestClass()]
    public class SLLListTests
    {
        private bool arraysEqual(string [] first, string[] second)
        {
            if (first.Length != second.Length)
            {
                return false;
            }
            for (int i = 0; i < first.Length; i++)
            {
                if (first[i] != second[i])
                {
                    return false;
                }
            }
            return true;
        }
        
        [TestMethod()]
        public void BigTest2()
        {
            var list = new myArrayList();
            Assert.AreEqual(0, list.ToArray().Length);
            list.Add("A");
            Assert.AreEqual(list.contains("A").theString, "A");

            Assert.IsNull(list.contains("B"));
            list.Add("B");
            Assert.AreEqual(list.contains("A").theString, "A");
            Assert.IsTrue(arraysEqual(new string[] {"A", "B"}, list.ToArray()));

            list = new myArrayList();
            list.Add("A");
            list.Add("B");
            list.Add("C");
            list.Add("D");
            Assert.IsTrue(arraysEqual(new string[] {"A", "B", "C", "D"}, list.ToArray()));
            list.Remove(list.contains("B"));
            Assert.IsTrue(arraysEqual(new string[] {"A", "C", "D"}, list.ToArray()));
            list.Remove(list.contains("D"));
            Assert.IsTrue(arraysEqual(new string[] { "A", "C" }, list.ToArray()));
            list.Remove(list.contains("A"));
            Assert.IsTrue(arraysEqual(new string[] { "C"}, list.ToArray()));
            list.Remove(list.contains("C"));
            Assert.IsTrue(arraysEqual(new string[] { }, list.ToArray()));
        }

        [TestMethod()]
        public void BigTest()
        {
            var list = new SLLList();
            Assert.AreEqual(0, list.ToArray().Length);
            list.Add("A");
            Assert.AreEqual(list.contains("A").theString, "A");

            Assert.IsNull(list.contains("B"));
            list.Add("B");
            Assert.AreEqual(list.contains("A").theString, "A");
            Assert.IsTrue(arraysEqual(new string[] { "A", "B" }, list.ToArray()));

            list = new SLLList();
            list.Add("A");
            list.Add("B");
            list.Add("C");
            list.Add("D");
            Assert.IsTrue(arraysEqual(new string[] { "A", "B", "C", "D" }, list.ToArray()));
            list.Remove(list.contains("B"));
            Assert.IsTrue(arraysEqual(new string[] { "A", "C", "D" }, list.ToArray()));
            list.Remove(list.contains("D"));
            Assert.IsTrue(arraysEqual(new string[] { "A", "C" }, list.ToArray()));
            list.Remove(list.contains("A"));
            Assert.IsTrue(arraysEqual(new string[] { "C" }, list.ToArray()));
            list.Remove(list.contains("C"));
            Assert.IsTrue(arraysEqual(new string[] { }, list.ToArray()));
        }
    }
}