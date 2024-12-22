using System;
using System.Collections.Generic;

namespace ExampleProject.mytask_rest
{
    internal class UserForGetRequest
    {
        public Address address { get; set; }
        public Company company { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public class Address
        {
            public Geo geo { get; set; }

            public string street { get; set; }
            public string suite { get; set; }
            public string city { get; set; }
            public string zipcode { get; set; }
            public class Geo
            {
                public string lat { get; set; }
                public string lng { get; set; }

                public Geo(string lat, string lng)
                {
                    this.lat = lat;
                    this.lng = lng;
                }

                public override bool Equals(object? obj)
                {
                    return obj is Geo geo &&
                           lat == geo.lat &&
                           lng == geo.lng;
                }

                public override int GetHashCode()
                {
                    return HashCode.Combine(lat, lng);
                }
            }

            public Address(string street, string suite, string city, string zipcode, Geo geo)
            {
                this.street = street;
                this.suite = suite;
                this.city = city;
                this.zipcode = zipcode;
                this.geo = geo;
            }
            public override bool Equals(object? obj)
            {
                return obj is Address address &&
                       EqualityComparer<Geo>.Default.Equals(geo, address.geo) &&
                       street == address.street &&
                       suite == address.suite &&
                       city == address.city &&
                       zipcode == address.zipcode;
            }
            public override int GetHashCode()
            {
                return HashCode.Combine(geo, street, suite, city, zipcode);
            }
        }
        public string phone { get; set; }
        public string website { get; set; }
        public class Company
        {
            public string name { get; set; }
            public string catchPhrase { get; set; }
            public string bs { get; set; }

            public Company(string name, string catchPhrase, string bs)
            {
                this.name = name;
                this.catchPhrase = catchPhrase;
                this.bs = bs;
            }
            public override bool Equals(object? obj)
            {
                return obj is Company company &&
                       name == company.name &&
                       catchPhrase == company.catchPhrase &&
                       bs == company.bs;
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(name, catchPhrase, bs);
            }
        }
        public UserForGetRequest(int id, string name, string username, string email, string website, string phone, Address address, Company company)
        {
            this.id = id;
            this.name = name;
            this.username = username;
            this.email = email;
            this.website = website;
            this.phone = phone;
            this.address = address;
            this.company = company;
        }

        public override bool Equals(object? obj)
        {
            return obj is UserForGetRequest test &&
                   EqualityComparer<Address>.Default.Equals(address, test.address) &&
                   EqualityComparer<Company>.Default.Equals(company, test.company) &&
                   id == test.id &&
                   name == test.name &&
                   username == test.username &&
                   email == test.email &&
                   phone == test.phone &&
                   website == test.website;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(address, company, id, name, username, email, phone, website);
        }
    }
}
