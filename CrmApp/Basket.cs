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

    public void ShowCategories()
    {
      int howManyLow = 0;
      int howManyMedium = 0;
      int howManyHi = 0;
      foreach (Product p in Products)
      {
        if (p.GetRange() == "low") howManyLow++;
        if (p.GetRange() == "medium") howManyMedium++;
        if (p.GetRange() == "hi") howManyHi++;

      }
      Console.WriteLine($"howManyLow= {howManyLow}");
      Console.WriteLine($"howManyMedium= {howManyMedium}");
      Console.WriteLine($"howManyHi= {howManyHi}");
    }




  }
}
