using NUnit.Framework;
using WorkshopStub.Repositories;
using WorkshopStub.Services;

namespace WorkshopStub.Test
{
    [TestFixture]
    internal class StockServiceTest
    {
        [Test]
        public void CheckAvailable_ShouldReturnTrue_WhenQuantityGreaterThan0()
        {
            // arrange
            var stub = new ItemRepository_Stub();
            stub.ReturnObject = new Models.ItemModel() { Quantity = 1 };

            StockService service = new StockService(stub);

            // act
            var result = service.CheckAvailable("Some Id");

            // assert
            Assert.AreEqual(true, result);
        }

        [Test]
        public void CheckAvailable_ShouldReturnFalse_WhenQuantityIsZero()
        {
            // arrange
            var stub = new ItemRepository_Stub();
            stub.ReturnObject = new Models.ItemModel() { Quantity = 0 };

            StockService service = new StockService(stub);

            // act
            var result = service.CheckAvailable("Some Id");

            // assert
            Assert.AreEqual(false, result);
        }
    }
}