using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class AddressRepository
    {
        /// <summary>
        /// Retrieve one address.
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public Address Retrieve(int addressId)
        {
            Address address = new Address(addressId);

            if (addressId == 1)
            {
                address.AddressType = 1;
                address.StreetLine1 = "Bag End";
                address.StreetLine2 = "Bagshot row";
                address.City = "Hobbiton";
                address.State = "Shire";
                address.Country = "Middle Earth";
                address.PostalCode = "144";
            }

            return address;
        }

        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            var addressList = new List<Address>();
            Address address = new Address(1);
            {
                address.AddressType = 1;
                address.StreetLine1 = "Bag End";
                address.StreetLine2 = "Bagshot row";
                address.City = "Hobbiton";
                address.State = "Shire";
                address.Country = "Middle Earth";
                address.PostalCode = "144";
            }
            addressList.Add(address);

            address = new Address(2);
            {
                address.AddressType = 2;
                address.StreetLine1 = "Green Dragon";
                address.City = "Bywater";
                address.State = "Shire";
                address.Country = "Middle Earth";
                address.PostalCode = "146";
            }
            addressList.Add(address);

            return addressList;
        }


        /// <summary>
        /// Saves the current address.
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        public bool Save(Address address)
        {
            return true;
        }
    }
}
