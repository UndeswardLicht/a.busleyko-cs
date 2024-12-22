using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProject.mytask_rest.Models
{
    internal class PostForPostRequest
    {
        public int userId { get; set; }
        public string title { get; set; }
        public string body { get; set; }

        public PostForPostRequest(int userId, string title, string body)
        {
            this.userId = userId;
            this.title = title;
            this.body = body;
        }
    }
}
