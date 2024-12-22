using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProject.mytask_rest
{
    internal class PostForGetRequest
    {
        public int userId { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public string body { get; set; }

        public PostForGetRequest(int userId, int id, string title, string body)
        {
            this.userId = userId;
            this.id = id;
            this.title = title;
            this.body = body;
        }   
    }
}
