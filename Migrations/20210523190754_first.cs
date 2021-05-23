using Microsoft.EntityFrameworkCore.Migrations;

namespace AndenSemesterProjekt.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Attendant",
                columns: table => new
                {
                    AttendantID = table.Column<int>(type: "int", maxLength: 5, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attendant", x => x.AttendantID);
                });

            migrationBuilder.CreateTable(
                name: "Driver",
                columns: table => new
                {
                    DriverID = table.Column<int>(type: "int", maxLength: 5, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Driver", x => x.DriverID);
                });

            migrationBuilder.CreateTable(
                name: "Routes",
                columns: table => new
                {
                    RouteID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DriverID = table.Column<int>(type: "int", nullable: false),
                    AttendantID = table.Column<int>(type: "int", nullable: false),
                    NrOfSeats = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    StartAdress = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EndAdress = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ETA = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    PickupPoints = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Routes", x => x.RouteID);
                    table.ForeignKey(
                        name: "FK_Routes_Attendant_AttendantID",
                        column: x => x.AttendantID,
                        principalTable: "Attendant",
                        principalColumn: "AttendantID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Routes_Driver_DriverID",
                        column: x => x.DriverID,
                        principalTable: "Driver",
                        principalColumn: "DriverID",
                        onDelete: ReferentialAction.Cascade);
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
                name: "Routes");

            migrationBuilder.DropTable(
                name: "Attendant");

            migrationBuilder.DropTable(
                name: "Driver");
        }
    }
}
