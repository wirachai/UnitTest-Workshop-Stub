using WorkshopStub.Models;

namespace WorkshopStub.Repositories
{
    public interface IItemRepository
    {
        ItemModel Get(string itemId);
    }
}