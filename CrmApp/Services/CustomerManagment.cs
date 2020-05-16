using CrmApp.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CrmApp.Services
{
  public class CustomerManagement : ICustomerManagement
  {
    private CrmAppDbContext db;

    public CustomerManagement(CrmAppDbContext _db)
    {
      db = _db;
    }


    //CRUD
    // create read update delete


    /// <summary>
    /// Method for creating a customer
    /// </summary>
    /// <param name="custOption"></param>
    /// <returns></returns>
    public Customer CreateCustomer(CustomerOption custOption)
    {
      Customer customer = new Customer
      {
        FirstName = custOption.FirstName,
        LastName = custOption.LastName,
        Address = custOption.Address,
        Dob = custOption.Dob,
        Email = custOption.Email,
        Active = true,
        Balance = 0,
      };


      db.Customers.Add(customer);
      db.SaveChanges();

      return customer;
    }





    /// <summary>
    /// Method that finds a customer searching by Id
    /// </summary>
    /// <param name="CustomerId"></param>
    /// <returns></returns>
    public Customer FindCustomerById(int CustomerId)
    {
      return db.Customers.Find(CustomerId);
    }


    public List<Customer> FindCustomerByName(CustomerOption custOption)
    {
      return db.Customers
          .Where(cust => cust.LastName == custOption.LastName)
          .Where(cust => cust.FirstName == custOption.FirstName)
          .ToList();
    }


    public List<Customer> GetAllCustomers()
    {
      return db.Customers.ToList();
    }



    /// <summary>
    /// Method that updates a customers info
    /// </summary>
    /// <param name="custOption"></param>
    /// <param name="customerId"></param>
    /// <returns></returns>
    public Customer Update(CustomerOption custOption, int customerId)
    {

      Customer customer = db.Customers.Find(customerId);

      if (custOption.FirstName != null)
        customer.FirstName = custOption.FirstName;
      if (custOption.LastName != null)
        customer.LastName = custOption.LastName;
      if (custOption.Email != null)
        customer.Email = custOption.Email;
      if (custOption.Address != null)
        customer.Address = custOption.Address;

      db.SaveChanges();
      return customer;
    }


    /// <summary>
    /// Method that deletes a customers info
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public bool DeleteCustomerById(int id)
    {

      Customer customer = db.Customers.Find(id);
      if (customer != null)
      {
        db.Customers.Remove(customer);
        db.SaveChanges();
        return true;
      }
      return false;

    }

    public bool SoftDeleteCustomerById(int id)
    {
      Customer customer = db.Customers.Find(id);
      if (customer != null)
      {
        customer.Active = false;
        db.SaveChanges();
        return true;
      }
      return false;
    }



  }
}

