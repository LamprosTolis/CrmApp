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
        ChocolateProduct.Print();

        Product JuiceProduct = ui.CreateProduct();
        JuiceProduct.Print();





        Console.WriteLine("Total price of products: " + ChocolateProduct.TotalCost+JuiceProduct.TotalCost);

        Console.ReadLine();
      }



      //Declaration of a method(s)

     /* static string DoWork(string message)
      {

        string Product;

        Console.WriteLine("Hello Code.Hub buds!\n");
        Product = Console.ReadLine();

        //Console.WriteLine(Product);

        return Product;
      }*/



    }
  }















}
