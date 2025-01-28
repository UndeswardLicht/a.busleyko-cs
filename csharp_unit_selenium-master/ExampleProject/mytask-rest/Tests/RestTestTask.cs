using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using ExampleProject.mytask_rest.Models;
using ExampleProject.mytask_rest.Utils;
using NUnit.Framework;
using NUnit.Framework.Internal;
using NUnit.Framework.Legacy;
using RestSharp;



namespace ExampleProject.mytask_rest
{
    internal class RestTestTask
    {
        private static string URL = "https://jsonplaceholder.typicode.com";
        private static RestClientOptions options = new RestClientOptions(URL)
        {
            MaxTimeout = 1000
        };
        private static RestClient client = new RestClient(options);

        UserForGetRequest testUser = new UserForGetRequest(id: 5, name: "Chelsey Dietrich", username: "Kamren",
            email: "Lucio_Hettinger@annie.ca", website: "demarco.info", phone: "(254)954-1289",
            new UserForGetRequest.Address(street: "Skiles Walks", suite: "Suite 351",
                city: "Roscoeview", zipcode: "33263",
                new UserForGetRequest.Address.Geo(lat: "-31.8129", lng: "62.5342")),
            new UserForGetRequest.Company(name: "Keebler LLC",
                catchPhrase: "User-centric fault-tolerant solution",
                bs: "revolutionize end-to-end systems"));

        [Test]
        public void GetAllPosts()
        {
            //1. Send GET Request to get all posts(/posts).
            //->>
            //Status code is 200.
            //The list in response body is json.
            //Posts are sorted ascending(by id).

            RestRequest request = new RestRequest("posts", Method.Get);
            RestResponse response = client.Get(request);
            string? jsonString = response.Content.ToString();

            var listOfPosts = JsonSerializer.Deserialize<List<PostForGetRequest>>(jsonString);
            List<int> ids = new List<int>();
            if (listOfPosts != null)
            {
                foreach (var post in listOfPosts)
                {
                    ids.Add(post.id);
                }
            }
            ClassicAssert.IsTrue((int)response.StatusCode == 200);
            ClassicAssert.IsTrue(response.ContentType.Equals("application/json"));
            ClassicAssert.IsTrue(TestUtils.IsListSortedAscending(ids));


        }

        [Test]
        public void GetSpecificPost()
        {
            //2. Send GET request to get post with id = 99(/ posts / 99)
            //->>
            //Status code is 200
            //Post information is correct: userId is 10, id is 99, title and body aren't empty.
            RestRequest request = new RestRequest("posts/99", Method.Get);
            RestResponse response = client.Get(request);

            string? jsonString = response.Content.ToString();
            PostForGetRequest? post = JsonSerializer.Deserialize<PostForGetRequest>(jsonString);

            ClassicAssert.IsTrue((int)response.StatusCode == 200);
            ClassicAssert.IsTrue(post.userId == 10);
            ClassicAssert.IsTrue(post.id == 99);
            ClassicAssert.IsNotEmpty(post.title);
            ClassicAssert.IsNotEmpty(post.body);

        }

        [Test]
        public void GetSpecificPostWithInvalidIdTest()
        {
            //3. Send GET request to get post with id = 150(/ posts/150).
            //->>
            //Status code is 404.
            //Response body is empty
            RestRequest request = new RestRequest("posts/150", Method.Get);
            RestResponse response = client.Get(request);

            string? jsonString = response.Content.ToString();
            PostForGetRequest? post = JsonSerializer.Deserialize<PostForGetRequest>(jsonString);

            ClassicAssert.IsTrue((int)response.StatusCode == 404);
            ClassicAssert.IsNull(post.body);
        }

        [Test]
        public void PostWithSpecificValidId()
        {
            string randomTitle = "Amazing title";
            string randomBody = "Not less impressive body";

            //4. Send POST request to create post with userId = 1
            //and random body and random title(/posts).
            //->>
            //Status code is 201.
            //Post information is correct: title, body, userId match data from request,
            //id is present in response
            RestRequest request = new RestRequest("posts", Method.Post);
            PostForPostRequest post = new PostForPostRequest(1, randomTitle, randomBody);
            request.AddJsonBody(post);

            RestResponse response = client.Post(request);
            string? jsonString = response.Content.ToString();
            PostForGetRequest? smth = JsonSerializer.Deserialize<PostForGetRequest>(jsonString);

            ClassicAssert.IsTrue((int)response.StatusCode == 201);
            ClassicAssert.IsTrue(smth.title.Equals(post.title));
            ClassicAssert.IsTrue(smth.userId.Equals(post.userId));
            ClassicAssert.IsTrue(smth.body.Equals(post.body));
            ClassicAssert.IsNotNull(smth.id);
        }

        [Test]
        public void GetAllUsers()
        {
            //5. Send GET request to get users(/ users).
            //->>
            //Status code is 200.
            //The list in response body is json.
            //User(id= 5) data equals to:
            // ....

            RestRequest request = new RestRequest("users/5", Method.Get);
            RestResponse response = client.Get(request);

            string? jsonString = response.Content?.ToString();
            var users = JsonSerializer.Deserialize<List<UserForGetRequest>>(jsonString);
            //.First<UserForGetRequest>();     

            UserForGetRequest? userToFind = users?.Find(user => user.id == 5); 
            ClassicAssert.IsTrue((int)response.StatusCode == 200);
            ClassicAssert.IsTrue(response?.ContentType?.Equals("application/json"));
            ClassicAssert.IsTrue(userToFind?.Equals(testUser));
        }

        [Test]
        public void GetSpecificUser()
        {
            //6. Send GET request to get user with id = 5(/ users/ 5).
            //->>
            //Status code is 200.
            //User data matches with user data in the previous step.
            RestRequest request = new RestRequest("users/5", Method.Get);
            RestResponse response = client.Get(request);

            string? jsonString = response.Content.ToString();
            UserForGetRequest? user = JsonSerializer.Deserialize<UserForGetRequest>(jsonString);

            ClassicAssert.IsTrue((int)response.StatusCode == 200);
            ClassicAssert.IsTrue(user.Equals(testUser));
        }
    }
}
