using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Models;
using WebApplication.Services;

namespace WebApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private IUserService myService;

        public UserController(IUserService myService)
        {
            this.myService = myService;
        }

        [HttpGet("/api/users")]
        public ActionResult<List<User>> GetUsers()
        {
            return myService.GetAllUsers();
        }

        [HttpPost("/api/users")]
        public ActionResult<User> AddUser(User user)
        {
            myService.AddUser(user);
            return user;
        }

        [HttpPut("/api/users/{id}")]
        public ActionResult<User> UpdateUser(int id, User user)
        {
            myService.UpdateUser(id, user);
            return user;
        }

        [HttpDelete("/api/users/{id}")]
        public ActionResult<int> DeleteUser(int id)
        {
            myService.DeleteUser(id);
            return id;
        }
    }
}