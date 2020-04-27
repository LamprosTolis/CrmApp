using System;

namespace CrmApp
{
  class Program
  {
    class MyClass
    {


      public static void Main()
      {
        Ui ui = new Ui();

        Product ChocolateProduct = ui.CreateProduct();

        if (ChocolateProduct != null)
        {
          ChocolateProduct.Print();
        }

        decimal total = ChocolateProduct.TotalCost;
        Console.WriteLine(total);
        Console.ReadLine();
      }

    }
  }















}
