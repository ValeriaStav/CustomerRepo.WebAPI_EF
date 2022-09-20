using CustomerManagement.BusinessEntities;
using CustomerManagement.Interfaces;
using CustomerManagement.Repositories;
using System;
using System.Collections.Generic;

namespace CustomerRepo.WebForms
{
    public partial class AddressesList : System.Web.UI.Page
    {
        private readonly IRepository<Address> _addressRepository;
        public List<Address> Addresses { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadAddressesFromDatabase();
        }
        public AddressesList()
        {
            _addressRepository = new AddressRepository();
        }
        /*public AddressesList(IRepository<Address> addressRepository)
        {
            _addressRepository = addressRepository;
        }*/
        public void LoadAddressesFromDatabase()
        {
            Addresses = _addressRepository.GetAll();
        }
    }
}