using System;
using System.Collections.Generic;

namespace CrmApp
{
  class Program
  {
    class MyClass
    {


      public static void Main()
      {
        Ui ui = new Ui();

        Product Chocolate = ui.CreateProduct();
        Product Juice = ui.CreateProduct();
        Product Fruit = ui.CreateProduct();
        Basket basket = new Basket();

        for (int i = 0; i < 3; i++ )
        {
          basket.AddProduct(Chocolate);
          basket.AddProduct(Juice);
          basket.AddProduct(Fruit);
        }

        if (Chocolate != null)
        {
          Chocolate.Print();
        }



        List<Product> products = new List<Product>
            {
                Chocolate, Juice,  Fruit                
            };

        int howManyLow = 0;
        int howManyMedium = 0;
        int howManyHi = 0;

        Console.WriteLine($"howManyLow= {howManyLow}");
        Console.WriteLine($"howManyMedium= {howManyMedium}");
        Console.WriteLine($"howManyHi= {howManyHi}");

        Console.WriteLine("----Not preferred approach------");

        for (int i = 0; i < products.Count; i++)
        {
          Console.WriteLine(products[i]);
        }

        Console.WriteLine("-------Not preferred approach-------");
        int index = 0;
        while (index < products.Count)
        {
          Console.WriteLine(products[index]);
          index++;
        }









        decimal total = Chocolate.TotalCost;
        Console.WriteLine(total);
        Console.ReadLine();
      }

    }
  }















}
