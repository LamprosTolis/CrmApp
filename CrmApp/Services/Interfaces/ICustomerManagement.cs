using CrmApp.Options;
using System.Collections.Generic;

namespace CrmApp.Services
{
  public interface ICustomerManagement
  {
    Customer CreateCustomer(CustomerOption custOption);
    bool DeleteCustomerById(int id);
    Customer FindCustomerById(int CustomerId);
    List<Customer> FindCustomerByName(CustomerOption custOption);
    List<Customer> GetAllCustomers();
    bool SoftDeleteCustomerById(int id);
    Customer Update(CustomerOption custOption, int customerId);
  }
}