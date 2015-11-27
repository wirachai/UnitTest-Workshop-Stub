using WorkshopStub.Models;

namespace WorkshopStub.Repositories
{
    public class ItemRepository
    {
        public ItemModel Get(string itemId)
        {
            // this is fake object because we don't intend to connect database.
            return new ItemModel() { ItemId = itemId, Quantity = 1 };
        }
    }
}