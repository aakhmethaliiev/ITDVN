using System;
using EventCarImitation;
using EventCarImitation.Controller;
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
            _target = new CarControls();
        }

        [TestMethod]
        public void CarGoesFasterTest()
        {
            
        }
    }
}
