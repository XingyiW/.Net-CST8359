﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2.Models
{
    public class Roles
    {
        [Key]
        public int RoleId
        {
            get;
            set;
        }

        [Required]
        [StringLength(1000)]
        public string Name
        {
            get;
            set;
        }
    }
}
