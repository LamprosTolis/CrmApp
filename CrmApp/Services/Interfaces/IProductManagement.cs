using CrmApp.Options;

namespace CrmApp.Services
{
  public interface IProductManagement
  {
    Product CreateProduct(ProductOption prodOption);
    bool DeleteProductById(int id);
    Product FindProductById(int id);
    Product Update(ProductOption prodOption, int productId);
  }
}