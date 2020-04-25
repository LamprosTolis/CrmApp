using System;

namespace CrmApp
{
  class Program
  {
    class MyClass
    {


      public static void Main()
      {
        //string returnedProduct;
        //string message = "Give me the product name:";

        Product Chocolate = new Product
        {
          Code = "A1",
          Name = "Toblerone",
          Price = 1.5m,
          Quantity = 10
        };

         Chocolate.Print();

        Product Juice = new Product
        {
          Code = "A2",
          Name = "Amita",
          Price = 1.2m,
          Quantity = 15
        };

        Juice.Print();


        decimal total;
        total = Chocolate.GetTotalCost() + Juice.GetTotalCost();
        Console.WriteLine("Total price of products: " + total);

        Console.ReadLine();
      }







      //Declaration of a method(s)

      static string DoWork(string message)
      {

        string Product;

        Console.WriteLine("Hello Code.Hub buds!\n");
        Product = Console.ReadLine();

        //Console.WriteLine(Product);

        return Product;
      }



    }
  }















}
