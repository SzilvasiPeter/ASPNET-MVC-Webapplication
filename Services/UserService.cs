using System.Collections.Generic;
using WebApplication.Models;

namespace WebApplication.Services
{
    public class UserService : IUserService
    {
        private List<User> myUsers;

        public UserService()
        {
            myUsers = new List<User>();
        }

        public List<User> GetAllUsers()
        {
            return myUsers;
        }

        public User AddUser(User userItem)
        {
            myUsers.Add(userItem);
            return userItem;
        }

        public User UpdateUser(int userId, User userItem)
        {
            for (int i = 0; i < myUsers.Count; i++)
            {
                if (myUsers[i].Id == userId)
                {
                    myUsers[i] = userItem;
                }
            }

            return userItem;
        }

        public int DeleteUser(int userId)
        {
            for (int i = 0; i < myUsers.Count; i++)
            {
                if (myUsers[i].Id == userId)
                {
                    myUsers.RemoveAt(i);
                }
            }

            return userId;
        }
    }
}