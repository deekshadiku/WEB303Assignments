using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Pms.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    Price = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    ImageUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ImageUrl", "Name", "Price", "Quantity" },
                values: new object[] { 1, "noimage", "Iphone", 1000, 10 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ImageUrl", "Name", "Price", "Quantity" },
                values: new object[] { 2, "noimage", "Iphone12", 100, 10 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ImageUrl", "Name", "Price", "Quantity" },
                values: new object[] { 3, "noimage", "Iphone13", 1000, 10 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
