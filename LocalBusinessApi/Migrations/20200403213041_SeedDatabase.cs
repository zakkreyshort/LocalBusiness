using Microsoft.EntityFrameworkCore.Migrations;

namespace LocalBusinessApi.Migrations
{
    public partial class SeedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BannerImage",
                table: "Categories",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "BannerImage",
                value: "https://www.singleplatform.com/wp-content/uploads/2018/12/5-Tips-for-Improving-Restaurant-Ambiance.jpg");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "BannerImage",
                value: "https://library.pdx.edu//wp-content/uploads/searchbytype.jpg");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "BannerImage",
                value: "https://cdn.vox-cdn.com/thumbor/NvYSxjc7qAtvSNcWh8jHvr4xZ24=/1400x1400/filters:format(jpeg)/cdn.vox-cdn.com/uploads/chorus_asset/file/19418125/Dina_Avila_Two_Wrongs_DSC5187_.jpg");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                column: "BannerImage",
                value: "https://www.portlandoregon.gov/shared/cfm/slb.cfm?id=660391");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 1,
                columns: new[] { "Body", "ImageSource", "Title" },
                values: new object[] { "Fast food", "https://bloximages.chicago2.vip.townnews.com/tdn.com/content/tncms/assets/v3/editorial/7/c6/7c6c4aa8-45fe-554a-8ff9-4749d0bb988b/5bb739e16271f.image.jpg", "Burgerville" });

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 2,
                columns: new[] { "ImageSource", "Title" },
                values: new object[] { "https://www.southeastexaminer.com/wp-content/uploads/2018/02/alittle-library-Carlos-West.jpg", "Pdx Library" });

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 3,
                columns: new[] { "Body", "ImageSource", "Title" },
                values: new object[] { "Nice", "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcSAD5XlgMYKr6yRDJAfVfHgFM7FUm1viOsr9tIHN4fOQYkwQQkM&usqp=CAU", "Urban Famer" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BannerImage",
                table: "Categories");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 1,
                columns: new[] { "Body", "ImageSource", "Title" },
                values: new object[] { "Test Restaurant", "#", "Test1" });

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 2,
                columns: new[] { "ImageSource", "Title" },
                values: new object[] { "#", "Test2" });

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 3,
                columns: new[] { "Body", "ImageSource", "Title" },
                values: new object[] { "Test Restaurant 2", "#", "Test3" });
        }
    }
}
