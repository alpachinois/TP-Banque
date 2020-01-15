using Nancy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace UserServiceYnov.UserService.Models
{
    public class LoginResponse
    {
        public bool IsAuthenticated { get; set; }
        public HttpStatusCode Code { get; set; }
        public Guid Token { get; set; }
    }
}
