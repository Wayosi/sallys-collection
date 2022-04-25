using Microsoft.EntityFrameworkCore;
using sallys_collection.EFModels;
using sallys_collection.Models.Data;
using sallys_collection.Models.ViewModels;
using sallys_collection.Repositories.Interfaces;

namespace sallys_collection.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly CollectionContext _collectionContext;
        private readonly CollectionDataContext _collectionDataContext;

        public ProductRepository(CollectionDataContext collectionContext)
        {
            _collectionContext = collectionContext.CollectionContext;
        }

        public async Task<List<ProductViewModel>> GetAllProducts()
        {
            try
            {
                return await _collectionContext.Product
                    .Include(p => p.ProductType)
                    .Select(p => new ProductViewModel
                    {
                        ProductId = p.ProductId,
                        Name = p.Name,
                        Cost = p.Cost,
                        MainImage = p.MainImage,
                        ProductTypeId = p.ProductTypeId,
                        ProductType = p.ProductType.Name
                    })
                    .ToListAsync();
            }
            catch (Exception)
            {
                return new List<ProductViewModel>();
            }
        }
    }
}
