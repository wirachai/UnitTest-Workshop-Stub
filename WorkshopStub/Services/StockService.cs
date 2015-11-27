using WorkshopStub.Repositories;

namespace WorkshopStub.Services
{
    public class StockService
    {
        public ItemRepository ItemRepository { get; set; }

        public StockService()
        {
            ItemRepository = new ItemRepository();
        }

        public StockService(ItemRepository itemRepo)
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