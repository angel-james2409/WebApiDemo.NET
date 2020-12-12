using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiDemo.Controllers
{
    public class BookingController : ApiController
    {
        static List<String> names = new List<string>()
        {
            "facepack","massage","fullbody massage","manecure","pedicure"
        };
        public IEnumerable<string> Get()
        {
            return names;
        }
        public string Get(int id)
        {
            return names[id];
        }
    public void Post([FromBody]String value)
        {
            names.Add(value);
        }
        public void Delete(int id)
        {
            names.RemoveAt(id);
        }
        public void Put(int id,[FromBody] String value)
        {
            names[id]=value;
        }

    }
}
