﻿namespace BookStoreApp.API.Models.User
{
    public class UserDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Role { get; set; }


    }

    public class LoginUserDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }   
}
