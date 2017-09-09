using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FitHub.Web.Domain
{
    public class GymWorkout
    {
        public int Id { get; set; }

        public string UserId { get; set; }
        public ApplicationUser User { get; set; }

        public string Name { get; set; }
        public int? Sets { get; set; }
        public int? Reps { get; set; }
        public DateTime Date { get; set; }
    }
}