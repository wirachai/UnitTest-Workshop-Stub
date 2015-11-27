using Moq;
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
            StockService service = SetUpServiceWithStub(1);

            // act
            var result = service.CheckAvailable("Some Id");

            // assert
            Assert.AreEqual(true, result);
        }

        [Test]
        public void CheckAvailable_ShouldReturnFalse_WhenQuantityIsZero()
        {
            // arrange
            StockService service = SetUpServiceWithStub(0);

            // act
            var result = service.CheckAvailable("Some Id");

            // assert
            Assert.AreEqual(false, result);
        }

        private StockService SetUpServiceWithStub(int quantity)
        {
            var stub = new Mock<IItemRepository>();
            stub.Setup(x => x.Get("Some Id"))
                .Returns(new Models.ItemModel() { Quantity = quantity });

            StockService service = new StockService(stub.Object);
            return service;
        }
    }
}