using System;
using ExceptionWprkersApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExceptionWprkersAppTests
{
    [TestClass]
    public class UserLogicTests
    {
        private UserLogic _userLogic;

        [TestInitialize]
        public void Init()
        {
            _userLogic = new UserLogic();
        }

        [TestMethod]
        [ExpectedException(typeof(UserLogic.YearEnteredException))]
        public void AddNewWorkerTest_EarlyYear_GetException()
        {
            //Arrange
            //Act
            _userLogic.AddNewWorker("", "", 1999);
            //Assert
        }

        [TestMethod]
        [ExpectedException(typeof(UserLogic.YearEnteredException))]
        public void AddNewWorkerTest_LateYear_GetException()
        {
            //Arrange
            //Act
            _userLogic.AddNewWorker("", "", 2020);
            //Assert
        }

        [TestMethod]
        public void AddNewWorkerTest_Year_NotException()
        {
            //Arrange
            //Act
            try
            {
                _userLogic.AddNewWorker("", "", 2019);
                
            }
            catch (Exception)
            {
                //Assert
                Assert.Fail();
            }
        }
    }
}
