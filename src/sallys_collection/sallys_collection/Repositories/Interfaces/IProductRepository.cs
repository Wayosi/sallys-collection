using sallys_collection.Models.ViewModels;

namespace sallys_collection.Repositories.Interfaces
{
    public interface IProductRepository
    {
        Task<List<ProductViewModel>> GetAllProducts();
    }
}
