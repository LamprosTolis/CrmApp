using System;
using System.Collections.Generic;
using System.Text;

namespace CrmApp
{
  class Basket
  {
    private List<Product> Products { get; set; }

    public Customer Customer { get; set;}


    public Basket()
    {
      Products = new List<Product>();
    }



    public void AddProduct(Product product)
    {
      Products.Add(product);
    }


    public decimal TotalCost()
    {
      decimal totalCost = 0;
      foreach(Product p in Products)
      {
        totalCost += p.TotalCost;
      }
      return totalCost;
    }


    public void Print()
    {
      foreach (Product p in Products)
      {
        Console.WriteLine(p);

      }
    }
  }
}
