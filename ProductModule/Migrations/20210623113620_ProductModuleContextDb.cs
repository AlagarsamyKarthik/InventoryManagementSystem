using Microsoft.EntityFrameworkCore.Migrations;

namespace ProductModule.Migrations
{
    public partial class ProductModuleContextDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Prod_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Prod_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prod_Desc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prod_Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Prod_Qty = table.Column<int>(type: "int", nullable: false),
                    Prod_Status = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Prod_Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");
        }
    }
}
