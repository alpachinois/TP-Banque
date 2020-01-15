using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Nancy;
using Nancy.ModelBinding;
using UserLogin.LoginService.Database;
using UserServiceYnov.LoginService.Models;
using UserServiceYnov.UserService.Models;

namespace UserLogin.LoginService.Module
{
    public class LoginModule: NancyModule
    {
        public LoginModule() : base("/ynov")
        {
            Post("/login", parameters =>
            {
                LoginRequest request = this.Bind<LoginRequest>();
                LoginResponse r = this.Login(request);
                return r;
            });

            Get("/CheckAuth/{token}", parameters =>            
                this.CheckTokenValidity(parameters.token)                
            );
        }

        private LoginResponse Login(LoginRequest request)
        {
            Guid token = Guid.NewGuid();
            LoginResponse result = new LoginResponse()
            {
                IsAuthenticated = LoginDatabase.UserDatabase.Any(u => u.Email.Equals(request.Email, StringComparison.CurrentCultureIgnoreCase) && u.Password.Equals(request.Password, StringComparison.InvariantCulture))
            };
            if (result.IsAuthenticated)
            {
                LoginDatabase.ConnectedUsers.Add(token, DateTime.UtcNow);
                result.Code = HttpStatusCode.OK;
                result.Token = token;
            }
            else
                result.Code = HttpStatusCode.Unauthorized;
            return result;
        }

        private LoginResponse CheckTokenValidity(string token)
        {
            Guid guid = new Guid(token);
            LoginResponse result = new LoginResponse()
            {
                IsAuthenticated = LoginDatabase.ConnectedUsers.Any(u => u.Key == guid && u.Value <= DateTime.UtcNow.AddMinutes(30)),
                Token = guid
            };
            if (result.IsAuthenticated)
            {
                LoginDatabase.ConnectedUsers[guid] = DateTime.UtcNow;
                result.Code = HttpStatusCode.OK;
            }
            else
                result.Code = HttpStatusCode.Unauthorized;
            return result;
        }
    }
}
