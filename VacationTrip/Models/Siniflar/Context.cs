
using Microsoft.EntityFrameworkCore;

namespace VacationTrip.Models.Siniflar
{
    public class Context : DbContext
    {
        public Context(DbContextOptions dbContextOptions) : base(dbContextOptions) 
        {

        }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<AdresBlog> AdresBlogs { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Hakkimizda> Hakkimizdas { get; set; }
        public DbSet<Yorumlar> Yorumlars { get; set; }
        public DbSet<İletisim> İletisims { get; set; }

    }
}
