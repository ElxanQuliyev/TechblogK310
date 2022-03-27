using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityFramework
{
    public class BlogDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder option)
        {
            option.UseSqlServer(@"Server =.\;Database=BlogK310DB;Trusted_Connection=true;MultipleActiveResultSets=True");
        }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Tecnology" },
                new Category { Id = 2, Name = "Business" },
                new Category { Id = 3, Name = "Programming" }
            );

            builder.Entity<Blog>().HasData(
                new Blog
                {
                    Id = 1,
                    Title = "Say hello to real handmade office furniture! Clean & beautiful design",
                    CategoryId = 3,
                    Description = "Lorem 1",
                    PhotoUrl = "https://www.free-css.com/assets/files/free-css-templates/preview/page244/tech-blog/assets/images/upload/tech_03.jpg"
                },
                new Blog
                {
                    Id = 2,
                    Title = "Do not make mistakes when choosing web hosting",
                    CategoryId = 1,
                    Description = "Lorem 2",
                    PhotoUrl = "https://www.free-css.com/assets/files/free-css-templates/preview/page244/tech-blog/assets/images/upload/tech_01.jpg"
                },
                new Blog
                {
                    Id = 3,
                    Title = "The most reliable Galaxy Note 8 images leaked",
                    CategoryId = 2,
                    Description = "Lorem",
                    PhotoUrl = "https://www.free-css.com/assets/files/free-css-templates/preview/page244/tech-blog/assets/images/upload/tech_menu_08.jpg"
                }
            );
        }
    }
}
