using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectName.Application.Entities
{
    public class User : BaseEntity
    {
        [Required(ErrorMessage = "Name is required")]
        [MaxLength(50)]
        public string Username { get; set; } = default!;

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress]
        public string Email { get; set; } = default!;
        [Required(ErrorMessage = "Password is required")]
        [MinLength(6)]
        public string Password { get; set; } = default!;

        public User()
        {

        }
        public User(string username, string email, string password)
        {

            Username = username;
            Email = email;
            Password = password;
        }
    }
}
