using Microsoft.EntityFrameworkCore;
using sallys_collection.EFModels;
using sallys_collection.Helpers;

namespace sallys_collection.Models.Data
{
    public class CollectionDataContext
    {
        public CollectionContext CollectionContext { get; private set; }

        private string WomensClothingProductTypeId = EncryptionHelper.EncryptId(1);
        private string LadiesBagsProductTypeId = EncryptionHelper.EncryptId(2);
        private string FootwearProductTypeId = EncryptionHelper.EncryptId(3);

        public CollectionDataContext()
        {
            var options = new DbContextOptionsBuilder<CollectionContext>()
            .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
            .EnableSensitiveDataLogging(true)
            .Options;

            CollectionContext = new CollectionContext(options);

            AddProductTypes().GetAwaiter().GetResult();

            AddWomensClothingProducts().GetAwaiter().GetResult();

            AddLadiesBagsProducts().GetAwaiter().GetResult();

            AddFootwearProducts().GetAwaiter().GetResult();

            CollectionContext.SaveChanges();
        }

        private async Task AddProductTypes()
        {
           await CollectionContext.ProductType.AddRangeAsync(
                new List<ProductType>
                {
                     new ProductType
                    {
                        ProductTypeId = WomensClothingProductTypeId,
                        Name = "Women's Clothing",
                        Active = true
                    },
                     new ProductType
                    {
                        ProductTypeId = LadiesBagsProductTypeId,
                        Name = "Ladies Bags",
                        Active = true
                    },
                     new ProductType
                    {
                        ProductTypeId = FootwearProductTypeId,
                        Name = "Footwear",
                        Active = true
                    }
                }   
            );
               
        }

        private async Task AddWomensClothingProducts()
        {
            await CollectionContext.Product.AddRangeAsync(
                    new List<Product>
                    {
                        new Product
                        {
                            ProductId = EncryptionHelper.EncryptId(1),
                            Name = "WC0001",
                            Cost = 20,
                            MainImage = "",
                            ProductTypeId = WomensClothingProductTypeId,
                        }
                    }
                );
        }

        private async Task AddLadiesBagsProducts()
        {
            await CollectionContext.Product.AddRangeAsync(
                    new List<Product>
                    {
                        new Product
                        {
                            ProductId = EncryptionHelper.EncryptId(2),
                            Name = "LB0001",
                            Cost = 20,
                            MainImage = "",
                            ProductTypeId = LadiesBagsProductTypeId
                        }
                    }
                );
        }

        private async Task AddFootwearProducts()
        {
            await CollectionContext.Product.AddRangeAsync(
                    new List<Product>
                    {
                        new Product
                        {
                            ProductId = EncryptionHelper.EncryptId(3),
                            Name = "FW0001",
                            Cost = 20,
                            MainImage = "",
                            ProductTypeId = FootwearProductTypeId
                        }
                    }
                );
        }
    }
}
