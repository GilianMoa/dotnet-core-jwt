using System.Collections.Generic;
using System.Linq;
using dotnet_core_jwt.Models;

namespace dotnet_core_jwt
{
    public static class UserRepository
    {
        public static User GetUser(string username, string password)
        {
            var users = new List<User>();
            users.Add(new User { Id = 1, UserName = "Gilian", Password = "123", Role = "Manager" });
            users.Add(new User { Id = 2, UserName = "Sameeli", Password = "123", Role = "Employee" });

            return users.FirstOrDefault(x => x.UserName.ToLower() == username.ToLower() && x.Password == password);
        }
    }
}