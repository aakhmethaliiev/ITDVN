using System;
using System.Collections.Generic;
using GenericsMyList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GenericMyListTest
{
    [TestClass]
    public class MyListTest
    {
        private MyList<int> _listOfInt;

        [TestInitialize]
        public void Init()
        {
            _listOfInt = new MyList<int>();
        }

        [TestMethod]
        public void AddTest()
        {
            _listOfInt.Add(10);
            _listOfInt.Add(20);
            var expectedList = new List<int> {10, 20};
            Assert.AreEqual(10,_listOfInt[0]);
            Assert.AreEqual(20,_listOfInt[1]);
        }

        [TestMethod]
        public void AddTestCollectionAssert()
        {
            _listOfInt.Add(10);
            _listOfInt.Add(20);
            var expectedList = new List<int> {10, 20};
            CollectionAssert.AreEqual(expectedList, _listOfInt);
        }

        [TestMethod]
        public void MyListExtensionTest()
        {
            _listOfInt.Add(10);
            _listOfInt.Add(20);
            var expectedList = new List<int> {10, 20};
            CollectionAssert.AreEqual(expectedList, _listOfInt.GetArray());
        }
    }
}
