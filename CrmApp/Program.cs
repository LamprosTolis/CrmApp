using System;

namespace CrmApp
{
  class Program
  {
    class MyClass
      {


      public static void Main()
      {
        string returnedProduct;
        string message = "Give me the product name:";


        //method call
        returnedProduct = DoWork(message);
        Console.WriteLine(returnedProduct);
        Console.ReadLine();
      }




      //Declaration of a method
      static string DoWork(string message)
      {

          string Product;

          Console.WriteLine("Hello Code.Hub buds!");
          Product = Console.ReadLine();

          //Console.WriteLine(Product);

          return Product;
      }



    }
  }















}
