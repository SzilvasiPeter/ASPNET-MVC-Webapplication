using System.Collections.Generic;
using WebApplication.Models;

namespace WebApplication.Services
{
    public interface IUserService
    {
        List<User> GetAllUsers();
        
        User AddUser(User userItem);
        
        User UpdateUser(int userId, User userItem);
        
        int DeleteUser(int userId);
    }
}