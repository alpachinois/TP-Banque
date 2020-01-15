using Nancy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserServiceYnov.UserService.Models;
using UserServiceYnov.UserService.Database;

namespace UserServiceYnov.UserService.Module
{
    public class UserModule : NancyModule
    {
        public UserModule() : base("/ynov")
        {
            Get("/{email}", parameters => GetUserResponse(new UserRequest() { Email = parameters.email }));
        }

        private UserResponse GetUserResponse(UserRequest request)
        {
            UserResponse result = new UserResponse()
            {
                User = UserDatabaseExemple.UserDatabase.FirstOrDefault(u => u.Email.Equals(request.Email, StringComparison.CurrentCultureIgnoreCase))
            };
            return result;
        }
    }
}
