using CrmApp.Models;
using CrmApp.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CrmApp.Services
{
  public class BasketManagement : IBasketManagement
  {
    private CrmAppDbContext db;

    public BasketManagement(CrmAppDbContext _db)
    {
      db = _db;
    }

    /// <summary>
    /// Creating a basket. BasketOption contains the CustomerId
    ///                  that we want to relate the basket with
    /// </summary>
    /// <param name="baskOption"></param>
    /// <returns></returns>
    public Basket CreateBasket(BasketOption baskOption)
    {
      CustomerManagement cstMng = new CustomerManagement(db);
      Basket basket = new Basket
      {
        Customer = cstMng.FindCustomerById(baskOption.CustomerId)
      };

      db.Baskets.Add(basket);
      db.SaveChanges();
      return basket;
    }

    /// <summary>
    /// Adding a product to a basket
    /// </summary>
    /// <param name="bskProd"></param>
    /// <returns></returns>
    public BasketProduct AddProduct(BasketProductOption bskProd)
    {
      BasketProduct basketProduct = new BasketProduct
      {
        Basket = db.Baskets.Find(bskProd.BasketId),
        Product = db.Products.Find(bskProd.ProductId)
      };
      db.BasketProducts.Add(basketProduct);
      db.SaveChanges();
      return basketProduct;
    }

    /// <summary>
    /// Find a customers baskets by the customer Id
    /// </summary>
    /// <param name="custId"></param>
    /// <returns></returns>
    public List<Basket> FindCustomerBaskets(int custId)
    {
      return db.Baskets
          .Where(basket => basket.Customer.CustomerId == custId)
          .ToList();
    }


    /// <summary>
    /// find basket by Id
    /// </summary>
    /// <param name="basketId"></param>
    /// <returns></returns>
    public Basket FindBasketById(int basketId)
    {
      return db.Baskets.Find(basketId);
    }


    /// <summary>
    /// Remove a product from the basket
    /// </summary>
    /// <param name="bskProdOpt"></param>
    /// <returns></returns>
    public bool RemoveProduct(BasketProductOption bskProdOpt)
    {

      BasketProduct bskProd = db.BasketProducts.Find(bskProdOpt);

      if (bskProd != null)
      {
        db.BasketProducts.Remove(bskProd);
        db.SaveChanges();
        return true;
      }
      return false;
    }
  }
}
