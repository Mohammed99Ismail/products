using Microsoft.EntityFrameworkCore.Migrations;

namespace Product.Web.Api.Migrations
{
    public partial class SeedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("insert into ProductTable (Name,Photo,Price,LastUpdate) values ('T-Shirt','https://static.nike.com/a/images/t_PDP_1280_v1/f_auto,q_auto:eco/0f84a075-2cc6-4065-b646-e32568d208a1/sportswear-t-shirt-JxbcVx.jpg',19.0,GETDATE())");
            migrationBuilder.Sql("insert into ProductTable (Name,Photo,Price,LastUpdate) values ('Shoes','https://images.pexels.com/photos/19090/pexels-photo.jpg?auto=compress&cs=tinysrgb&dpr=1&w=500',19.0,GETDATE())");
            migrationBuilder.Sql("insert into ProductTable (Name,Photo,Price,LastUpdate) values ('Chair','https://images-na.ssl-images-amazon.com/images/I/81tp3nAUyLL._SL1500_.jpg',32.0,GETDATE())");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("delete from ProductTable");
        }
    }
}
