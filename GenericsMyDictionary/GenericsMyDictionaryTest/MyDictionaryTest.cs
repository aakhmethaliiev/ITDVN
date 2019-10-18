using System;
using GenericsMyDictionary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GenericsMyDictionaryTest
{
    [TestClass]
    public class MyDictionaryTest
    {
        
        [TestMethod]
        public void AddTest()
        {
            var target = new MyDictionary<int, string>();
            target.Add(0, "null");
            target.Add(1, "one");
            Assert.AreEqual("null", target[0]);
            Assert.AreEqual("one", target[1]);
        }

        [TestMethod]
        public void IndexTest()
        {
            var target = new MyDictionary<string, string>();
            target.Add("0", "null");
            target.Add("1", "one");
            Assert.AreEqual("null", target["0"]);
            Assert.AreEqual("one", target["1"]);
        }

        [TestMethod]
        public void CountTest()
        {
            var target = new MyDictionary<string, string>();
            target.Add("0", "null");
            target.Add("1", "one");
            Assert.AreEqual(2, target.Count);
        }
    }
}
