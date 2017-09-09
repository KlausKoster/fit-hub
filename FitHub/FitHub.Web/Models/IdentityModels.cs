using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using FitHub.Web.Domain;

namespace FitHub.Web.Models
{

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<CardioWorkout> CardioWorkouts { get; set; }
        public DbSet<GymWorkout> GymWorkouts { get; set; }
        public DbSet<WeightLog> WeightLogs { get; set; }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}