using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ProjectRagnarock.Models
{
    public class AdminLogin
    {
        public AdminLogin()
        {
        }
        [Required]
        public string Username { get; set; }
        [Required]
        [StringLength(4)]
        public string Password { get; set; }
        //Her validere vi om admin login passet til det der bliver skrevet ude i adminlogins siden
        public bool Validation(string username, string password)
        {
           if (username == "admin" && password == "1234")
            {
                return true;
            }
            else 
            { 
                return false; 
            }
        }
    }

}
