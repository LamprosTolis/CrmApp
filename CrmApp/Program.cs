using CrmApp.Models;
using CrmApp.Options;
using CrmApp.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CrmApp
{
  class Program
  {
    class MyClass
    {


      public static void Main()
      {

        //CustomerOption custOpt = new CustomerOption
        //{
        //  FirstName = "Tester222",
        //  LastName = "Test",
        //  Address = "TestCity",
        //  Email = "test@gmail.com",
        //};

        using CrmAppDbContext db = new CrmAppDbContext();
        CustomerManagement custMangr = new CustomerManagement(db);

        ////testing the creation of a customer
        //Customer customer = custMangr.CreateCustomer(custOpt);
        //Console.WriteLine(
        //$"Id= {customer.CustomerId} Name= {customer.FirstName} Address= {customer.Address}");



        ////testing reading a customer
        //customer = custMangr.FindCustomerById(2);
        //if (customer != null)
        //  Console.WriteLine(
        //      $"Id= {customer.CustomerId} Name= {customer.FirstName} Address= {customer.Address}");


        ////testing updating
        //CustomerOption custChangingAddress = new CustomerOption
        //{
        //  Address = "Lamia"
        //};
        //customer = custMangr.Update(custChangingAddress, 1);
        //Console.WriteLine(
        //    $"Id= {customer.CustomerId} Name= {customer.FirstName} Address= {customer.Address}");


        ////testing deletion

        //bool result = custMangr.DeleteCustomerById(2);
        //Console.WriteLine($"Result = {result}");
        //customer = custMangr.FindCustomerById(2);
        //if (customer != null)
        //{
        //  Console.WriteLine(
        //  $"Id= {customer.CustomerId} Name= {customer.FirstName} Address= {customer.Address}");

        //}
        //else
        //{
        //  Console.WriteLine("not found");
        //}



        ProductOption prOpt = new ProductOption
        {
          Name = "portokalia",
          Price = 1.20m,
          Quantity = 10
        };

        ProductManagement prodMangr = new ProductManagement(db);

        Product product = prodMangr.CreateProduct(prOpt);

        BasketManagement baskMangr = new BasketManagement(db);

        BasketOption baskOption = new BasketOption
        {
          CustomerId = 5
        };

        Basket basket = baskMangr.CreateBasket(baskOption);
        BasketProductOption bskProdOpt = new BasketProductOption
        {
          BasketId =basket.Id ,
          ProductId = 1
        };

        //System.NullReferenceException

        BasketProduct baskProd = baskMangr.AddProduct(bskProdOpt);

        basket.BasketProducts.ForEach(
                        baskProduct =>
                           Console.WriteLine(
                               db.BasketProducts
                               .Include(b => b.Product)
                               .Where(b => b.Id == baskProduct.Id)
                               .First()
                               .Product.Name)
                    );

        Console.ReadLine();
      }
    }
  }















}
