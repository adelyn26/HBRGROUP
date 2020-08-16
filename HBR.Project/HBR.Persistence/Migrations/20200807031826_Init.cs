using Microsoft.EntityFrameworkCore.Migrations;

namespace HBR.Persistence.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    id_Categories = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    _Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.id_Categories);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    id_User = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    _Name = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Telephone = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    _Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.id_User);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    id_Product = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    _Name = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: false),
                    Expiration = table.Column<string>(nullable: true),
                    _Provider = table.Column<string>(nullable: true),
                    Direction = table.Column<string>(nullable: true),
                    idCategoriesid_Categories = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.id_Product);
                    table.ForeignKey(
                        name: "FK_Product_Categories_idCategoriesid_Categories",
                        column: x => x.idCategoriesid_Categories,
                        principalTable: "Categories",
                        principalColumn: "id_Categories",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Product_idCategoriesid_Categories",
                table: "Product",
                column: "idCategoriesid_Categories");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
