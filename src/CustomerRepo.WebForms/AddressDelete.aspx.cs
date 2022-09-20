using CustomerManagement.BusinessEntities;
using CustomerManagement.Interfaces;
using CustomerManagement.Repositories;
using System;

namespace CustomerRepo.WebForms
{
    public partial class AddressDelete : System.Web.UI.Page
    {
        public IRepository<Address> _addressRepository;
        public AddressDelete()
        {
            _addressRepository = new AddressRepository();
        }
        public AddressDelete(IRepository<Address> addressRepository)
        {
            _addressRepository = addressRepository;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            var addressIdReq = Convert.ToInt32(Request.QueryString["addressId"]);
            _addressRepository.Delete(addressIdReq);
            Response.Redirect("AddressesList.aspx");
        }
    }
}