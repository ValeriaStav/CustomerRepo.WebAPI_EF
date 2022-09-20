using CustomerManagement.BusinessEntities;
using CustomerManagement.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomerManagement.EFRepositories
{
    public class EFCustomerRepository : IRepository<Customer>
    {
        private readonly GeoDBContext _context;

        public EFCustomerRepository()
        {
            _context = new GeoDBContext();
        }
        public void Create(Customer customer)
        {
            _context
                .Customers
                .Add(customer);
            _context.SaveChanges();
        }

        public Customer Read(int customerId)
        {
            return _context
                .Customers
                .FirstOrDefault(x => x.CustomerId == customerId);
        }

        public void Update(Customer customer)
        {
            _context
                .Entry(customer)
                .State = System.Data.Entity.EntityState.Modified;

            _context.SaveChanges();
        }

        public void Delete(int customerId)
        {
            var customer = _context
                .Customers
                .FirstOrDefault(x => x.CustomerId == customerId);

            _context.Customers.Remove(customer);

            _context.SaveChanges();
        }

        public void DeleteAll()
        {
            var customers = _context
                .Customers
                .ToList();

         // Быстрый способ

         //   _context.Database.ExecuteSqlCommand("DELETE FROM dbo.Addresses");
        //    _context.Database.ExecuteSqlCommand("DELETE FROM dbo.Customers");

            
            // Медленный способ (для общего развития)

            foreach (var customer in customers)
            {
                _context
                    .Customers
                    .Remove(customer);
            }
            _context.SaveChanges();
        }

        public List<Customer> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
