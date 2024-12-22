using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProject.mytask_rest.Models.NewFolder
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    internal class Root
    {
        private UserForGetRequest.Address address1;
        private UserForGetRequest.Company company1;

        public Root(int id, string name, string username, string email, string website, string phone, UserForGetRequest.Address address1, UserForGetRequest.Company company1)
        {
            this.id = id;
            this.name = name;
            this.username = username;
            this.email = email;
            this.website = website;
            this.phone = phone;
            this.address1 = address1;
            this.company1 = company1;
        }

        public int id { get; set; }
        public string name { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public Address address { get; set; }
        public string phone { get; set; }
        public string website { get; set; }
        public Company company { get; set; }
    }
}
