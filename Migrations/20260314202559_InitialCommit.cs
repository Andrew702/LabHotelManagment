using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LabHotelManagment.Migrations
{
    /// <inheritdoc />
    public partial class InitialCommit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "frontend",
            //    columns: table => new
            //    {
            //        user_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        pass_word = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Table", x => x.user_name);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "kitchen",
            //    columns: table => new
            //    {
            //        user_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        pass_word = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__kitchen__7628B51D2FDAF8B5", x => x.user_name);
            //    });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropTable(
            //    name: "frontend");

            //migrationBuilder.DropTable(
            //    name: "kitchen");
        }
    }
}
