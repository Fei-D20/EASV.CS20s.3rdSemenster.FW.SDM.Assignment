using EASV.CS20s._3rdSemenster.FW.SDM.Assignment.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace EASV.CS20s._3rdSemenster.FW.SDM.Assignment.Repository
{
    public class ReviewApplicationContext : DbContext
    {
        public ReviewApplicationContext(DbContextOptions<ReviewApplicationContext> options) : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Valuator> Valuators { get; set; }
        
    }
}