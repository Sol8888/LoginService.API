﻿
using BCrypt.Net;
namespace LoginService.API.API.Models

{
    public class LoginRequest
    {
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        
    }
}
