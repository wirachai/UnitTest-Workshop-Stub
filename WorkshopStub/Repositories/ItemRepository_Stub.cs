using WorkshopStub.Models;

namespace WorkshopStub.Repositories
{
    public class ItemRepository_Stub : IItemRepository
    {
        public ItemModel ReturnObject { get; set; }

        public ItemModel Get(string itemId)
        {
            return ReturnObject;
        }
    }
}