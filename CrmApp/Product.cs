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
      //return "Name= " + Name +"\n"
      //   + " Price= "+Price
      //   + " Quantity= " + Quantity
      //   + " TotalCost= " + TotalCost;
      // preferrable way using $
      return $"Name= {Name} Code= {Code} Price= {Price} Quantity= {Quantity} TotalCost= {TotalCost}";

    }

    public void Print()
    {
      Console.WriteLine(PrintToLine());
      Console.WriteLine();
    }



    //public void Print()
    //{
    //  Console.WriteLine(Name);
    //  Console.WriteLine(Price);
    //  Console.WriteLine(Quantity);
    //  Console.WriteLine(TotalCost);
    //}

    public void IncreasePrice(decimal percentage)
    {
      if (category == 1)
        Price = 1 + 0.1m;
      else
        Price *= (1 + percentage);
    }
  }
}
