using EASV.CS20s._3rdSemenster.FW.SDM.Assignment.Repository.Entities;
using Microsoft.EntityFrameworkCore;

namespace EASV.CS20s._3rdSemenster.FW.SDM.Assignment.Repository
{
    public class ReviewApplicationContext : DbContext
    {
        public ReviewApplicationContext(DbContextOptions<ReviewApplicationContext> options) : base(options)
        {
        }

        public DbSet<ReviewEntity> Reviews { get; set; }
    }
}