﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel;

namespace eTickets.Models
{
    public class ApplicationUser : IdentityUser
    {
        [DisplayName("Full Name")]
        public string FullName { get; set; }
    }
}
