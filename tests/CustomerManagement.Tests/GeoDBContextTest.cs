using CustomerManagement.EFRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagement.Tests
{
    public class GeoDBContextTest
    {

        [Fact]
        public void ShouldCreateGeoDBContext()
        {
            var context = new GeoDBContext();
            Assert.NotNull(context);

            Assert.NotNull(context.Customers);
            Assert.NotNull(context.Addresses);
        }

    }
}
