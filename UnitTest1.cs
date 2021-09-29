using AzureProject01.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;

namespace AzureProject01
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            ImageController controller = new ImageController();

            //Act
            ViewResult result = controller.Index() as ViewResult;

            //Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            ImageController controller = new ImageController();

            //Act
            ViewResult result = controller.LatestImage() as ViewResult;

            //Assert
            Assert.IsNotNull(result);
        }

    }
}
