using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Slight.Models;
using Slight.DAL;

namespace Slight.Controllers
{
    public class UserController : ApiController
    {
        private SlightContext db;

        public UserController()
        {
            this.db = new SlightContext();
        }

        public IEnumerable<User> GetAllUsers() 
        {
            return db.Users;
        }

        public User GetSingleUser(int id) 
        {
            return db.Users.FirstOrDefault(x => x.Id == id);
        }

        //TODO Cache
        //http://www.asp.net/web-api/overview/older-versions/build-restful-apis-with-aspnet-web-api

        public HttpResponseMessage Post(User User) 
        {
            this.db.Users.Add(User);
            var response = Request.CreateResponse<User>(System.Net.HttpStatusCode.Created, User);
            return response;
        }
    }
}
