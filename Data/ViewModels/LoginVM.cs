﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Data.ViewModels
{
    public class LoginVM
    {
        [Display(Name = "Email address")]
        [Required(ErrorMessage = "Email Address is required")]
        public string EmailAddress { get; set; }
        [Display(Name = "Email address")]
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

    }
}