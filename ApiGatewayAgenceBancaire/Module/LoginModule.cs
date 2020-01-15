using ApiGatewayAgenceBancaire.Models;
using Nancy;
using Nancy.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using UserServiceYnov.UserService.Models;

namespace ApiGatewayAgenceBancaire.Module
{
    public class LoginModule: NancyModule
    {
        public LoginModule(): base("/ynov")
        {
            Post("/login", parameters =>
            {
                LoginRequest request = this.Bind<LoginRequest>();
                LoginResponse r = this.Login(request);
                return r;
            });

            //Get("/CheckAuth/{token}", parameters =>
            //    this.CheckTokenValidity(parameters.token)
            //);
        }

        private LoginResponse Login(LoginRequest request)
        {
            LoginResponse result = new LoginResponse();

            HttpClient client = new HttpClient();


            return result;
        }
    }
}
