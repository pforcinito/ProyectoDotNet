using MyServiceWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyServiceWeb.Mapper
{
    public static class UserMapper
    {
        public static void Map(User user1, User user2)
        {
            user1.Name = user2.Name;
            user1.Email = user2.Email;
            user1.AttemptLogin = user2.AttemptLogin;
            user1.Birthday = user2.Birthday;
            user1.Locked = user2.Locked;
            user1.LogIn = user2.LogIn;
            user1.Nickname = user2.Nickname;
            user1.Password = user2.Password;
            user1.Surname = user2.Surname;            
        }
    }
}
