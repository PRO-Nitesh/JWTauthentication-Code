
using ApiProject.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiProject.Data
{
    public class AllContext : DbContext
    {
        public AllContext(DbContextOptions<AllContext> options) : base(options) { }

        public virtual DbSet<Users> Users { get; set; }
        //public virtual DbSet<User> User { get; set; }
    }
}
