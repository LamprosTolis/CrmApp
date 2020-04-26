using System;
using System.Collections.Generic;
using System.Text;

namespace CrmApp
{
  class Ui
  {

    public Product CreateProduct()
    {
      try
      {
        Product product = new Product();

        Console.WriteLine("Enter the product code: ");
        product.Code = Console.ReadLine();

        Console.WriteLine("Enter the product name: ");
        product.Name = Console.ReadLine();

        Console.WriteLine("Enter the product price: ");
        product.Price = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Enter the product's quantity: ");
        product.Price = int.Parse(Console.ReadLine());

        return product;
      }

      catch (Exception e)
      {
        Console.WriteLine(e);
        return null;
      }
    }
  }
}
