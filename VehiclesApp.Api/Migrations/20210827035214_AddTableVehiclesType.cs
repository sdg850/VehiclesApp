using Microsoft.EntityFrameworkCore.Migrations;

namespace VehiclesApp.Api.Migrations
{
    public partial class AddTableVehiclesType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VehiclesType",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehiclesType", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_VehiclesType_Description",
                table: "VehiclesType",
                column: "Description",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VehiclesType");
        }
    }
}
