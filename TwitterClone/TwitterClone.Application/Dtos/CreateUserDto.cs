using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TwitterClone.Application.Dtos
{
    public class CreateUserDto
    {
        [Required]
        [StringLength (50)]
        public required string FisrtName { get; set; }

        [Required]
        [StringLength(50)]
        public required string LastName { get; set; }

        [Required]
        [StringLength(50)]
        public required string Email { get; set; }
        public string? FirstName { get; internal set; }
    }
}
