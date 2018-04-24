using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoListVS3.Models;

namespace ToDoListVS3.Tests
{
    [TestClass]
    public class ItemTests
    {
        [TestMethod]
        public void GetDescription_ReturnsItemDescription_String()
        {
            //Arrange
            var item = new Item();
            item.Description = "Wash the dog";

            //Act
            var result = item.Description;

            //Assert
            Assert.AreEqual("Wash the dog", result);
        }
    }
}
