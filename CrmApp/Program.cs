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
        //var ui = new Ui();
        //var customer = ui.CreateCustomer();
        //var basket = ui.CreateBasket();

        var dbContext = new CrmAppDbContext();
        dbContext.Database.EnsureCreated();

        //Insert
        //var customer = new Customer()
        //{
        //  Name = " Tolis",
        //  Location = "Lamia"
        //};


        
        //dbContext.Add(customer);
        //dbContext.SaveChanges();

        //Select
        //var customers = dbContext.Set<Customer>()
        //  .Where(cust => cust.CustomerId == 1 && cust.Name == "Tolis - Papagiannis")
        //  .Single();

        //Console.WriteLine("Customer Name found: " + customers.Name);
        //Console.WriteLine("Customer Id found: " + customers.CustomerId);
        //Console.ReadLine();
        //Remove
        //dbContext.Remove(customer);
        //dbContext.SaveChanges();

      }
    }
  }















}
