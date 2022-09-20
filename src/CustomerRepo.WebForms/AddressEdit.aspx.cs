using CustomerManagement.BusinessEntities;
using CustomerManagement.Interfaces;
using CustomerManagement.Repositories;
using System;
using System.Web;

namespace CustomerRepo.WebForms
{
    public partial class AddressEdit : System.Web.UI.Page
    {
        private readonly IRepository<Address> _addressRepository;

        public AddressEdit()
        {
            _addressRepository = new AddressRepository();
        }

        public AddressEdit(IRepository<Address> addressRepository)
        {
            _addressRepository = addressRepository;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var addressIdReq = Convert.ToInt32(Request.QueryString["addressId"]);
                if (addressIdReq != 0)
                {
                    var address = _addressRepository.Read(addressIdReq);
                    customerId.Text = Convert.ToString(address.CustomerId);
                    addressLine1.Text = address.AddressLine;
                    addressLine2.Text = address.AddressLine2;
                    addressType.Text = address.AddressType;
                    city.Text = address.City;
                    postalCode.Text = address.PostalCode;
                    state.Text = address.State;
                    country.Text = address.Country;
                }
            }
        }

        public void OnClickSave(object sender, EventArgs e)
        {
            var address = new Address()
            {
                AddressId = Convert.ToInt32(Request.QueryString["addressId"]),
                CustomerId = Convert.ToInt32(customerId?.Text),
                AddressLine = addressLine1.Text,
                AddressLine2 = addressLine2.Text,
                AddressType = addressType.Text,
                City = city.Text,
                PostalCode = postalCode.Text,
                State = state.Text,
                Country = country.Text
            };
            if (Convert.ToInt32(Request.QueryString["addressId"]) == 0)
            {
                _addressRepository.Create(address);
            }
            else
            {
                _addressRepository.Update(address);
            }
            HttpContext.Current.Response.Redirect("AddressesList.aspx");
        }
    }
}