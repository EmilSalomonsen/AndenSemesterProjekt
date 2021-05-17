using Microsoft.EntityFrameworkCore.Migrations;

namespace AndenSemesterProjekt.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Attendants",
                columns: table => new
                {
                    AttendantID = table.Column<string>(type: "nchar(5)", fixedLength: true, maxLength: 5, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attendants", x => x.AttendantID);
                });

            migrationBuilder.CreateTable(
                name: "Drivers",
                columns: table => new
                {
                    DriverID = table.Column<string>(type: "nchar(5)", fixedLength: true, maxLength: 5, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drivers", x => x.DriverID);
                });

            migrationBuilder.CreateTable(
                name: "PickupPoints",
                columns: table => new
                {
                    PickupPointID = table.Column<string>(type: "nchar(5)", fixedLength: true, maxLength: 5, nullable: false),
                    PickupTime = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    Adress = table.Column<string>(type: "nchar(50)", fixedLength: true, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PickupPoints", x => x.PickupPointID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<string>(type: "nchar(5)", fixedLength: true, maxLength: 5, nullable: false),
                    Name = table.Column<string>(type: "nchar(50)", fixedLength: true, maxLength: 50, nullable: false),
                    Username = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "Routes",
                columns: table => new
                {
                    RouteID = table.Column<int>(type: "int", fixedLength: true, maxLength: 5, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DriverID = table.Column<string>(type: "nchar(5)", fixedLength: true, maxLength: 5, nullable: false),
                    AttendantID = table.Column<string>(type: "nchar(5)", fixedLength: true, maxLength: 5, nullable: false),
                    NrOfSeats = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    StartAdress = table.Column<string>(type: "nchar(50)", fixedLength: true, maxLength: 50, nullable: false),
                    EndAdress = table.Column<string>(type: "nchar(50)", fixedLength: true, maxLength: 50, nullable: false),
                    ETA = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    PickupPoints = table.Column<string>(type: "nchar(50)", fixedLength: true, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Routes", x => x.RouteID);
                    table.ForeignKey(
                        name: "FK__Routes__Attendan__2C3393D0",
                        column: x => x.AttendantID,
                        principalTable: "Attendants",
                        principalColumn: "AttendantID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Routes__DriverID__2B3F6F97",
                        column: x => x.DriverID,
                        principalTable: "Drivers",
                        principalColumn: "DriverID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Routes_AttendantID",
                table: "Routes",
                column: "AttendantID");

            migrationBuilder.CreateIndex(
                name: "IX_Routes_DriverID",
                table: "Routes",
                column: "DriverID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PickupPoints");

            migrationBuilder.DropTable(
                name: "Routes");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Attendants");

            migrationBuilder.DropTable(
                name: "Drivers");
        }
    }
}
