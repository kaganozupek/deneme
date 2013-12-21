using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using System.Web.Script.Serialization;
namespace WebAPI.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public HttpResponseMessage Get()
        {
            var RegisteredUsers = new List<Person>();
            RegisteredUsers.Add(new Person() { ID = 1, FirstName = "Bryon Hetrick Alfonso", LastName = "asd" });
            RegisteredUsers.Add(new Person() { ID = 2, FirstName = "Nicole Wilcox", LastName = "asd" });
            RegisteredUsers.Add(new Person() { ID = 3, FirstName = "Adrian Martinson", LastName = "asd" });
            RegisteredUsers.Add(new Person() { ID = 4, FirstName = "Nora Osborn", LastName = "asd" });

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            var serializedResult = serializer.Serialize(new Person() { ID = 1, FirstName = "Bryon Hetrick", LastName = "asd" });


            
            HttpResponseMessage message = new HttpResponseMessage()
            {
                Content = new StringContent(
                    serializedResult,
                    Encoding.UTF8,
                    "text/html"
                )
            };
            return message;
        }

        // GET api/values/5
        public string Get(int id)
        {
            
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}