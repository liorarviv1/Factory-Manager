using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;             //חובה
using WebApplicationFactory.Models;     //חובה



namespace WebApplicationFactory.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")] //חובה
    public class UserController : ApiController
    {
        private static UserBL userBL= new UserBL();
        // GET: api/User
        public IEnumerable<User> Get()
        {
            return userBL.GetAllUsers();
        }

        // GET: api/User/5
        public User Get(int id)
        {
            return userBL.GetUserId(id);
        }

        // POST: api/User
        public string Post(User user)
        {
            userBL.AddUser(user);
            return "User added";
        }

        // PUT: api/User/5
        public string Put(int id, User user)
        {
            userBL.UpdateUser(id, user);
            return "User updated";
        }

        // DELETE: api/User/5
        public string Delete(int id)
        {
            userBL.DeleteUser(id);
            return "User deleted";
        }
    }
}
