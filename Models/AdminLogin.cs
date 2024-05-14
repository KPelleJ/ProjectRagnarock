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
