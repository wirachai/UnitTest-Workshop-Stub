using WorkshopStub.Repositories;

namespace WorkshopStub.Services
{
    public class StockService
    {
        public IItemRepository ItemRepository { get; set; }

        public StockService()
        {
            ItemRepository = new ItemRepository();
        }

        public StockService(IItemRepository itemRepo)
        {
            ItemRepository = itemRepo;
        }

        public bool CheckAvailable(string itemId)
        {
            var model = ItemRepository.Get(itemId);
            return model.Quantity > 0;
        }
    }
}