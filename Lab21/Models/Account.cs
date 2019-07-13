using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab21.Models
{
    public class Account
    {
        public int Id { get; set; }

        [MinLength(2)]
        [MaxLength(18)]
        public string Username { get; set; }

        [MinLength(2)]
        [MaxLength(18)]
        public string Password { get; set; }

        [MinLength(2)]
        [MaxLength(18)]
        public string FirstName { get; set; }

        [MinLength(2)]
        [MaxLength(18)]
        public string LastName { get; set; }

        [Phone]
        public int Phone { get; set; }


        [MinLength(2)]
        [MaxLength(40)]
        [EmailAddress]
        public string Email { get; set; }

    }
}
