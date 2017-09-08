using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FitHub.Web.Domain
{
    public class WeightLog
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public double Weight { get; set; }
        public DateTime Date { get; set; }
    }
}