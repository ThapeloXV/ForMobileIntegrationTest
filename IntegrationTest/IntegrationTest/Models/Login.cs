using System;
using System.Collections.Generic;
using System.Text;

namespace IntegrationTest.Models
{
    class Login
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string AccessToken { get; set; }
        public string TokenType { get; set; }
        public string ExpiresIn { get; set; }
        public string Scope { get; set; }

    }
}
