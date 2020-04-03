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
                new Category { CategoryId = 1, Name = "Restaurant", Description = "Portland Cuisine", BannerImage = "https://www.singleplatform.com/wp-content/uploads/2018/12/5-Tips-for-Improving-Restaurant-Ambiance.jpg"},
                new Category { CategoryId = 2, Name = "Library", Description = "PDX Libraries", BannerImage = "https://library.pdx.edu//wp-content/uploads/searchbytype.jpg"},
                new Category { CategoryId = 3, Name = "Bar", Description = "PDX Bars", BannerImage = "https://cdn.vox-cdn.com/thumbor/NvYSxjc7qAtvSNcWh8jHvr4xZ24=/1400x1400/filters:format(jpeg)/cdn.vox-cdn.com/uploads/chorus_asset/file/19418125/Dina_Avila_Two_Wrongs_DSC5187_.jpg"},
                new Category { CategoryId = 4, Name = "Animal", Description = "Animals", BannerImage = "https://www.portlandoregon.gov/shared/cfm/slb.cfm?id=660391"}
            );
        builder.Entity<Place>()
            .HasData(
                new Place { PlaceId = 1, Title = "Burgerville", Body = "Fast food", AuthorId = 1, CategoryId = 1, ImageSource = "https://bloximages.chicago2.vip.townnews.com/tdn.com/content/tncms/assets/v3/editorial/7/c6/7c6c4aa8-45fe-554a-8ff9-4749d0bb988b/5bb739e16271f.image.jpg"},
                new Place { PlaceId = 2, Title = "Pdx Library", Body = "Test Library", AuthorId = 1, CategoryId = 2, ImageSource = "https://www.southeastexaminer.com/wp-content/uploads/2018/02/alittle-library-Carlos-West.jpg"},
                new Place { PlaceId = 3, Title = "Urban Famer", Body = "Nice", AuthorId = 1, CategoryId = 1, ImageSource = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcSAD5XlgMYKr6yRDJAfVfHgFM7FUm1viOsr9tIHN4fOQYkwQQkM&usqp=CAU"},
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