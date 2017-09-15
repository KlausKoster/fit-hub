using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FitHub.Web.Domain
{
    public class CardioWorkout
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }

        public string Activity { get; set; }
        public TimeSpan Duration { get; set; }
        public double? Distance { get; set; }
        public DateTime Date { get; set; }
    }
}