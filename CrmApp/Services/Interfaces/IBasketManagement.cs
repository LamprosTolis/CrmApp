using CrmApp.Models;
using CrmApp.Options;
using System.Collections.Generic;

namespace CrmApp.Services
{
  public interface IBasketManagement
  {
    BasketProduct AddProduct(BasketProductOption bskProd);
    Basket CreateBasket(BasketOption baskOption);
    Basket FindBasketById(int basketId);
    List<Basket> FindCustomerBaskets(int custId);
    bool RemoveProduct(BasketProductOption bskProdOpt);
  }
}