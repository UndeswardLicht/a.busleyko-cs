using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProject.mytask.RestTest
{
    internal class UserForRestTest
    {
        private Address address;
        private Company company;

        public UserForRestTest(string name, string username, string email, string website, string phone, Address address, Company company)
        {
            Name = name;
            Username = username;
            Email = email;
            Website = website;
            Phone = phone;
            this.address = address;
            this.company = company;
        }

        public string Name { get; }
        public string Username { get; }
        public string Email { get; }
        public class Address
        {
            private int zipcode;
            private Geo geo;

            public string Street { get; }
            public string Suite { get; }
            public string City { get; }
            public string Zipcode { get; }
            public class Geo
            {
                public double lat { get; }
                public double lng { get; }

                public Geo(double lat, double lng)
                {
                    this.lat = lat;
                    this.lng = lng;
                }
            }

            public Address(string street, string suite, string city, int zipcode, Geo geo)
            {
                Street = street;
                Suite = suite;
                City = city;
                this.zipcode = zipcode;
                this.geo = geo;
            }
        }
        public string Website { get; }
        public string Phone { get; }

        public class Company
        {
            public string Name { get; }
            public string CatchPhrase { get; }
            public string Bs { get; }

            public Company(string name, string catchPhrase, string bs)
            {
                Name = name;
                CatchPhrase = catchPhrase;
                Bs = bs;
            }
        }
    }
}
