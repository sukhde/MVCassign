using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCassignment1
{
    public class House
    {
        public int Id { get; set; }
        public int Value { get; set; }
        public int Lotsize { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int PostalCode { get; set; }


        public House(int value, int lotsize, string address, string city , string state, int postalcode)
        {
            Value = value;
            Lotsize = lotsize;
            Address = address;
            City = city;
            State = state;
            PostalCode = postalcode;
        }

    }
}