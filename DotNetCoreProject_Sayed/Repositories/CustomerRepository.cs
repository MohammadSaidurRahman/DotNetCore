using DotNetCoreProject_Sayed.Data;
using DotNetCoreProject_Sayed.Interface;
using DotNetCoreProject_Sayed.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreProject_Sayed.Repositories
{
    public class CustomerRepository: ICustomerRepository
    {
        private readonly ApplicationDbContext db;
        public CustomerRepository(ApplicationDbContext db)
        {
            this.db = db;
        }

        public Customer Add(Customer customer)
        {
            db.Customers.Add(customer);
            db.SaveChanges();

            return customer;
        }

        public Customer Delete(int id)
        {
            Customer customer = db.Customers.Find(id);
            if (customer != null)
            {
                db.Customers.Remove(customer);
                db.SaveChanges();
            }
            return customer;
        }

        public IEnumerable<Customer> GetAll()
        {
            return db.Customers;
        }

        public Customer GetCustomer(int id)
        {
            return db.Customers.Where(x => x.CustomerId == id).SingleOrDefault();
        }

        public Customer Update(Customer customer)
        {
            db.Entry(customer).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
            return customer;
        }
    }
}
