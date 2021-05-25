using Microsoft.EntityFrameworkCore.Migrations;

namespace AndenSemesterProjekt.Migrations
{
    public partial class myFirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PickupPoints",
                table: "Routes",
                type: "nchar",
                fixedLength: true,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nchar(50)",
                oldFixedLength: true,
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "ETA",
                table: "Routes",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "DriverID",
                table: "Routes",
                type: "nchar(5)",
                fixedLength: true,
                maxLength: 5,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nchar(5)",
                oldFixedLength: true,
                oldMaxLength: 5);

            migrationBuilder.AlterColumn<string>(
                name: "AttendantID",
                table: "Routes",
                type: "nchar(5)",
                fixedLength: true,
                maxLength: 5,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nchar(5)",
                oldFixedLength: true,
                oldMaxLength: 5);

            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    adminID = table.Column<int>(type: "int", fixedLength: true, maxLength: 5, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    adminFirstName = table.Column<string>(type: "nchar(50)", fixedLength: true, maxLength: 50, nullable: false),
                    adminLastName = table.Column<string>(type: "nchar(50)", fixedLength: true, maxLength: 50, nullable: false),
                    adminUsername = table.Column<string>(type: "nchar(50)", fixedLength: true, maxLength: 50, nullable: false),
                    adminPassword = table.Column<string>(type: "nchar(50)", fixedLength: true, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.adminID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.AlterColumn<string>(
                name: "PickupPoints",
                table: "Routes",
                type: "nchar(50)",
                fixedLength: true,
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nchar",
                oldFixedLength: true,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ETA",
                table: "Routes",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DriverID",
                table: "Routes",
                type: "nchar(5)",
                fixedLength: true,
                maxLength: 5,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nchar(5)",
                oldFixedLength: true,
                oldMaxLength: 5,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AttendantID",
                table: "Routes",
                type: "nchar(5)",
                fixedLength: true,
                maxLength: 5,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nchar(5)",
                oldFixedLength: true,
                oldMaxLength: 5,
                oldNullable: true);
        }
    }
}
