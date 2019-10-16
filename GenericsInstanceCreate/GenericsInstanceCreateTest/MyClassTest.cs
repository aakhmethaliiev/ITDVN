using GenericsInstanceCreate;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GenericsInstanceCreateTest
{
    [TestClass]
    public class MyClassTest
    {
        private TestClass _target;


        [TestMethod]
        public void FactoryMethodTest()
        {
            _target = MyClass<TestClass>.FactoryMethod();
            Assert.IsInstanceOfType(_target, typeof(TestClass));
        }
    }

    internal class TestClass
    {
        public TestClass()
        {

        }
    }
}
