using System;
using System.Collections.Generic;
using System.Text;

namespace CrmApp
{
  class Product
  {
    public string Code { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }



    public void Print()
    {
      Console.WriteLine(Code);
      Console.WriteLine(Name);
      Console.WriteLine(Price);
      Console.WriteLine(Quantity);
      Console.WriteLine(GetTotalCost());
      Console.WriteLine();
    }

    public void IncreasePrice (decimal percentage)
    {
      Price *= (1+ percentage);
    }

    public decimal GetTotalCost()
    {
      decimal totalCost;
      totalCost = Price * Quantity;
      return totalCost;
    }

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
