using CustomerManagement.BusinessEntities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagement.EFRepositories
{
    public class GeoDBContext : DbContext
    {
        public GeoDBContext()
            : base("Server=.\\SQLEXPRESS;Database=CustomerLib;User Id=sa;Trusted_Connection=True;")
        {

        }

        public IDbSet<Customer> Customers { get; set; }
        public IDbSet<Address> Addresses { get; set; }

    }
}
