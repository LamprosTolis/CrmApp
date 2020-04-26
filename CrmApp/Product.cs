using System;
using System.Collections.Generic;
using System.Text;

namespace CrmApp
{
  class Product
  {

    private int category;

    private string code;

    /// <summary>
    /// Properties
    /// </summary>
    public string Code
    {
      get { return "GR" + code; }
      set { code = value; }
    }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }

    public decimal TotalCost { get { return Price * Quantity; } }


    public Product(int category)
    {
      this.category = category;
    }

    //Default Constractor
    public Product()
    {

    }





    public void Print()
    {
      Console.WriteLine(Code);
      Console.WriteLine(Name);
      Console.WriteLine(Price);
      Console.WriteLine(Quantity);
      Console.WriteLine(TotalCost);
      Console.WriteLine();
    }

    public void IncreasePrice(decimal percentage)
    {
      if (category == 1)
        Price = 1 + 0.1m;
      else
        Price *= (1 + percentage);
    }

    /*public decimal GetTotalCost()
    {
      decimal totalCost;
      totalCost = Price * Quantity;
      return totalCost;
    }*/

    public void setCode(string code)
    {
      Code = code;
    }

    public string GetCode()
    {
      return Code;
    }

  }
}
