using System.Text.Json;
using System.Xml.Linq;
using NUnit.Framework;
using NUnit.Framework.Constraints;
using NUnit.Framework.Legacy;
using RestSharp;
using static OpenQA.Selenium.BiDi.Modules.Session.ProxyConfiguration;


namespace ExampleProject.mytask.RestTest
{
    internal class RestTestTask
    {
        private static string URL = "https://jsonplaceholder.typicode.com";
        private static RestClientOptions options = new RestClientOptions(URL)
        {
            MaxTimeout = 1000
        };
        private static RestClient client = new RestClient(options);

        UserForRestTest user = new UserForRestTest(name: "Chelsey Dietrich", username: "Kamren",
            email: "Lucio_Hettinger@annie.ca", website: "demarco.info", phone: "(254)954 - 1289",
            new UserForRestTest.Address(street: "Skiles Walks", suite: "Suite 351",
                city: "Roscoeview", zipcode: 33263,
                new UserForRestTest.Address.Geo(lat: -31.8129, lng: 62.5342)),
            new UserForRestTest.Company(name: "Keebler LLC",
                catchPhrase: "User - centric fault - tolerant solution",
                bs: "revolutionize end - to - end systems"));



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
            ClassicAssert.IsTrue((int)response.StatusCode == 200);
            ClassicAssert.IsTrue(response.ContentType.Equals("application/json"));

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

            JsonDocument doc = JsonDocument.Parse(response.Content.ToString());
            JsonElement root = doc.RootElement;
            int id = root.GetProperty("id").GetInt32();
            int userId = root.GetProperty("userId").GetInt32();
            string? title = root.GetProperty("title").GetString();
            string? body = root.GetProperty("body").GetString();
            ClassicAssert.IsTrue((int)response.StatusCode == 200);
            ClassicAssert.IsTrue(userId == 10);
            ClassicAssert.IsTrue(id == 99);
            ClassicAssert.IsNotEmpty(title);
            ClassicAssert.IsNotEmpty(body);

        }

        [Test]
        public void GetSpecificPostWithInvalidIdTest()
        {
            //3. Send GET request to get post with id = 150(/ posts / 150).
            //->>
            //Status code is 404.
            //Response body is empty
            RestRequest request = new RestRequest("posts/150", Method.Get);
            RestResponse response = client.Get(request);

            JsonDocument doc = JsonDocument.Parse(response.Content.ToString());
            JsonElement root = doc.RootElement;
            string? body = root.GetProperty("body").GetString();
            ClassicAssert.IsTrue((int)response.StatusCode == 404);
            ClassicAssert.IsEmpty(body);

        }

        [Test]
        public void PostWithSpecificValidId()
        {
            //4. Send POST request to create post with userId = 1 and random body and random title(/posts).
            //->>
            //Status code is 201.
            //Post information is correct: title, body, userId match data from request, id is present in response.
        }

        [Test]
        public void GetAllUsers()
        {
            //5. Send GET request to get users(/ users).
            //->>
            //Status code is 200.
            //The list in response body is json.
            //User(id= 5) data equals to:
            //name: Chelsey Dietrich
            //username: Kamren
            //email: Lucio_Hettinger @annie.ca
            //address:
            //street: Skiles Walks
            //suite: Suite 351
            //city: Roscoeview
            //zipcode: 33263
            //geo:
            //lat: -31.8129
            //lng: 62.5342
            //phone: (254)954 - 1289,
            //website: demarco.info
            //company:
            //name: Keebler LLC,
            //catchPhrase: User - centric fault - tolerant solution
            //bs: revolutionize end-to - end systems
        }

        [Test]
        public void GetSpecificUser()
        {
            //6. Send GET request to get user with id = 5(/ users / 5).
            //->>
            //Status code is 200.
            //User data matches with user data in the previous step.
            RestRequest request = new RestRequest("users/5", Method.Get);
            RestResponse response = client.Get(request);

            JsonDocument doc = JsonDocument.Parse(response.Content.ToString());
            JsonElement root = doc.RootElement;
            string? body = root.GetProperty("body").GetString();
            ClassicAssert.IsTrue((int)response.StatusCode == 404);
            ClassicAssert.IsEmpty(body);
        }
    }
}
