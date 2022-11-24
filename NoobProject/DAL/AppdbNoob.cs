using Microsoft.EntityFrameworkCore;
using NoobProject.Models;

namespace NoobProject.DAL
{
    public class AppdbNoob:DbContext
    {
        public AppdbNoob(DbContextOptions<AppdbNoob>options):base(options)
        {

        }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Slider>Sliders { get; set;}
        public DbSet<Category>categories { get; set; }  
        public DbSet<Tag> tags { get; set; }
        public DbSet<Brand> brands { get; set; }
        public DbSet<Product>products { get; set; } 
        public DbSet<ProductImage>productImages { get; set; }
        public DbSet<ProductTag>productTags { get; set; }

    }
}
