using DotNetCoreProject_Sayed.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreProject_Sayed.Interface
{
   public interface ICustomerRepository
    {
        Customer GetCustomer(int id);

        IEnumerable<Customer> GetAll();

        Customer Add(Customer customer);
        Customer Update(Customer customer);
        Customer Delete(int id);
    }
}
