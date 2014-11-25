﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TestWebApp.Controllers
{
    //[Authorize]
    public class ValuesController : ApiController
    {
        // GET api/values
        public string Get()
        {
            return this.Url.Request.RequestUri.PathAndQuery;
            //return new string[] { "value1", "value2" };
        }

        // GET api/values/5
      //  public string Get(int id)
      //  {
      //      return "value";
      //  }

        public string Get(string message)
        {
            return "The time is " + System.DateTime.Now.ToShortTimeString() + ", and I hate " + message;
        }

        // POST api/values
        public string Post([FromBody]string value)
        {
            return value;
        }
        //test
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
