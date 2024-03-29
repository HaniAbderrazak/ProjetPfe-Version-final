﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace WebClient.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public string Local { get; set; } = "en-GB";
        public string OrgId { get; set; }
    }
    public class organization
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
}
