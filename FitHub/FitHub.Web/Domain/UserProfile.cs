using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FitHub.Web.Models;
//using FitHub.Web.Domain.Enums;  Could do this if we left the namespace the other way due to folder structure

namespace FitHub.Web.Domain
{
    public class UserProfile
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }

        public int Height { get; set; }
        public Gender Gender { get; set; }
        public int Age { get; set; }

    }
}