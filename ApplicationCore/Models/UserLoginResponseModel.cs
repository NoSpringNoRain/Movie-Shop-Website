using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.VisualBasic;

namespace ApplicationCore.Models
{
    public class UserLoginResponseModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}