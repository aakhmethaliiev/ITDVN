using System;
using EventCarImitation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EventCarImitationTests
{
    [TestClass]
    public class CarControlsTests
    {
        private CarControls _target;

        [TestInitialize]
        public void Init()
        {
            _target = CarControlInit.GetCarControls();
        }

        [TestMethod]
        public void CarGoesFasterTest()
        {
            
        }
    }
}
