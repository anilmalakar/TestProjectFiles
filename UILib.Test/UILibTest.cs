using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BizLib;
using Moq;
using UILib;

namespace UILib.Test
{
    [TestClass]
    public class UILibTest
    {
        Mock<IBizData> _bizData;
        UI uiInstance;
        [TestInitialize]
        public void InIt()
        {
            _bizData = new Mock<IBizData>();

        }

        [TestMethod]
        public void UI_Constructor_Test()
        {
            uiInstance = new UI(_bizData.Object);
            Assert.IsNotNull(uiInstance);
        }

        [TestMethod]
        public void UI_Should_Return_Data()
        {
            _bizData.Setup(s => s.GetData()).Returns("This is test");
            uiInstance = new UI(_bizData.Object);
            var result = uiInstance.GetData();
            Assert.IsNotNull(uiInstance);
            Assert.AreEqual(result, "This is test");
        }
    }
}
