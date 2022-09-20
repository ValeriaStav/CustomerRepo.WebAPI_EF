using CustomerManagement.BusinessEntities;
using CustomerManagement.Interfaces;
using CustomerManagement.Repositories;
using System;

namespace CustomerRepo.WebForms
{
    public partial class AddressDeleteAll : System.Web.UI.Page
    {
        public IRepository<Address> _addressRepository;
        public AddressDeleteAll()
        {
            _addressRepository = new AddressRepository();
        }
        public AddressDeleteAll(IRepository<Address> addressRepository)
        {
            _addressRepository = addressRepository;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            _addressRepository.DeleteAll();
            Response.Redirect("AddressesList.aspx");
        }
    }
}