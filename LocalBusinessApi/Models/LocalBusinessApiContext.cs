using Microsoft.EntityFrameworkCore;

namespace LocalBusinessApi.Models
{
    public class LocalBusinessApiContext : DbContext
    {

        public DbSet<Category> Categories { get; set; }
        public DbSet<Place> Places { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<User> Users { get; set; }

        public LocalBusinessApiContext(DbContextOptions<LocalBusinessApiContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
        builder.Entity<Category>()
            .HasData(
                new Category { CategoryId = 1, Name = "Restaurant", Description = "Portland Cuisine"},
                new Category { CategoryId = 2, Name = "Library", Description = "PDX Libraries"},
                new Category { CategoryId = 3, Name = "Bar", Description = "PDX Bars"},
                new Category { CategoryId = 4, Name = "Animal", Description = "Animals"}
            );
        builder.Entity<Place>()
            .HasData(
                new Place { PlaceId = 1, Title = "Test1", Body = "Test Restaurant", AuthorId = 1, CategoryId = 1, ImageSource = "#"},
                new Place { PlaceId = 2, Title = "Test2", Body = "Test Library", AuthorId = 1, CategoryId = 2, ImageSource = "#"},
                new Place { PlaceId = 3, Title = "Test3", Body = "Test Restaurant 2", AuthorId = 1, CategoryId = 1, ImageSource = "#"},
                new Place { PlaceId = 4, Title = "Test4", Body = "Test Lib 2", AuthorId = 1, CategoryId = 2, ImageSource = "#"},
                new Place { PlaceId = 5, Title = "Test5", Body = "Test lib 3", AuthorId = 1, CategoryId = 2, ImageSource = "#"}
            );
        builder.Entity<User>()
            .HasData(
                new User { UserId = 1, Name = "name", Email = "123@email", Password = "1"},
                new User { UserId = 2, Name = "name2", Email = "123@email2", Password = "1"},
                new User { UserId = 3, Name = "name3", Email = "123@email3", Password = "1"},
                new User { UserId = 4, Name = "name4", Email = "123@email4", Password = "1"}
            );
        }
    }
}