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
        Customer customer = ui.CreateCustomer();
        Basket basket = ui.CreateBasket();
      }

    }
  }















}
