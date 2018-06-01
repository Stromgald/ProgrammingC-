using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace MyFirstApplication.Data.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(100)]
        public string Surname { get; set; }

        [StringLength(200)]
        public string Email { get; set; }
    }
}
