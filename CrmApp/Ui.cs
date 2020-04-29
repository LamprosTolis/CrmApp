using System;
using System.Collections.Generic;
using System.Text;

namespace CrmApp
{
  class Ui
  {
    private Basket basket;

    public Ui(Basket basket)
    {
      this.basket = basket;
    }

    public Ui()
    {

    }

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
        product.Quantity = int.Parse(Console.ReadLine());

        return product;
      }

      catch (Exception e)
      {
        Console.WriteLine(e);
        return null;
      }
    }

    public Customer CreateCustomer()
    {
      Customer customer = new Customer();
      Console.WriteLine("Enter your full name: \n");
      customer.Name = Console.ReadLine();

      Console.WriteLine("Enter your Id Number: \n");
      customer.Id = int.Parse(Console.ReadLine());

      Console.WriteLine("Enter your Location: \n");
      customer.Location = Console.ReadLine();

      return customer;
    }



    /// <summary>
    /// Menu for creating the basket menu
    /// </summary>
    /// <returns></returns>
    public int Menu()
    {
      Console.WriteLine("1. Add a product\n 2. Display basket\n 3. Show Categories\n 4. TotalCost\n 5. Diplay Customer info\n 0. Exit");
      Console.WriteLine("Enter your choice");
      int choice = 0;
      try
      {
        choice = int.Parse(Console.ReadLine());
        return choice;
      }
      catch (Exception e)
      {
        Console.WriteLine("Invaild choice!");

        return choice;
      }
    }


    public Basket CreateBasket()
    {
      Customer customer = new Customer();
      Basket basket = new Basket();
      int choice = Menu();

      do
      {
        choice = Menu();
        switch (choice)
        {
          case 1:
            Product product = CreateProduct();
            basket.AddProduct(product);
            break;
          case 2:
            basket.Print();
            break;
          case 3:
            basket.ShowCategories();
            break;
          case 4:
            Console.WriteLine("TotalCost= " + basket.TotalCost());
            break;
          ////case 5:
          ////  Console.WriteLine($"Customer name:{ customer.Name}\n Customer Id: {customer.Location} Customer Location: {customer.Location}");
          //  break;
          case 0:
            Console.WriteLine("You choose to exit");
            break;
        }
      }
      while (choice != 0);
      return basket;
    }



  }
}
