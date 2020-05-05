using CrmApp.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrmApp.Services
{
  public class ProductManagment
  {
    private CrmAppDbContext db;
    public ProductManagment(CrmAppDbContext _db)
    {
      db = _db;
    }


    //CRUD

    public Product CreateProduct(ProductOption prodOption)
    {
      Product product = new Product
      {
        Name = prodOption.Name,
        Price = prodOption.Price,
        Quantity = prodOption.Quantity
      };

      db.Add(product);
      db.SaveChanges();

      return product;
    }


      public Product FindProductById(int id)
      {

        Product product = db.Products.Find(id);
        return product;
      }

    public Product Update(ProductOption prodOption, int productId)
    {

      Product product = db.Products.Find(productId);

      if (prodOption.Name != null)
        product.Name = prodOption.Name;
      if (prodOption.Price < 0m)
        product.Price = prodOption.Price;
      if (prodOption.Quantity < 0)
        product.Quantity = prodOption.Quantity;

      db.SaveChanges();
      return product;
    }


    public bool DeleteProductById(int id)
    {

      Product product = db.Products.Find(id);
      if (product != null)
      {
        db.Products.Remove(product);
        db.SaveChanges();
        return true;
      }
      return false;

    }









  }
}
