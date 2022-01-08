using GeekShopping.Web.Models;

namespace GeekShopping.Web.Services.IServices
{
    public interface IProdudctService
    {
        Task<IEnumerable<ProductModel>> FindAllProducts();
        Task<ProductModel> FindProductById(long id);
        Task<bool> DeleteProduct(long id);
        Task<ProductModel> CreateProduct(ProductModel model);
        Task<ProductModel> UpdateProduct(ProductModel model);
    }
}
