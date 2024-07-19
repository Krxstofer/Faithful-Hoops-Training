using FaithfulHoopsTraining.Models;
using Microsoft.EntityFrameworkCore;

namespace FaithfulHoopsTraining.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
        
        }

        public DbSet<HoopSession> HoopSessions { get; set; }
        public DbSet<TrainSession> TrainSessions { get; set; }
        public DbSet<Address> Addresses { get; set; }
    }
}
