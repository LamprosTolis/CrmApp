using System;
using System.Collections.Generic;
using System.Text;

namespace CrmApp
{
  public class Product
  {

    private readonly int category;

    public string ProductId { get; set; }

    /// <summary>
    /// Properties
    /// </summary>

    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }

    public string Descreption { get; set; }

      public decimal TotalCost { get { return Price * Quantity; } }


    public Product(int _category)
    {
      category = _category;
    }

    //Default Constractor
    public Product()
    {
      
    }

    public string PrintToLine()
    {
      return $"Name= {Name} Price= {Price}";
    }

    public void Print()
    {
      Console.WriteLine(PrintToLine());
      Console.WriteLine();
    }

    public string GetRange()
    {
      if (Price < 1)
        return "low";
      else if (Price < 10)
        return "medium";
      else
        return "hi";
    }

    public void IncreasePrice(decimal percentage)
    {
      if (category == 1)
        Price = 1 + 0.1m;
      else
        Price *= (1 + percentage);
    }
  }
}
