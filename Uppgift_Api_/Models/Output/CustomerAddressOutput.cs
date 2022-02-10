﻿namespace Uppgift_Api_.Models.Output
{
    public class CustomerAddressOutput
    {
        public CustomerAddressOutput()
        {

        }

        public CustomerAddressOutput(string streetName, int postalCode, string city, string country)
        {
            StreetName = streetName;
            PostalCode = postalCode;
            City = city;
            Country = country;
        }

        public string StreetName { get; set; }
        public int PostalCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
}
