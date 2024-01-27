using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainsApi.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobTitle = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Locomotive",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SerialNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locomotive", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Trains",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trains", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Wagons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<int>(type: "int", nullable: false),
                    SittingCapacity = table.Column<int>(type: "int", nullable: false),
                    StandingCapacity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wagons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LocomotiveTrain",
                columns: table => new
                {
                    LocomotivesId = table.Column<int>(type: "int", nullable: false),
                    TrainsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocomotiveTrain", x => new { x.LocomotivesId, x.TrainsId });
                    table.ForeignKey(
                        name: "FK_LocomotiveTrain_Locomotive_LocomotivesId",
                        column: x => x.LocomotivesId,
                        principalTable: "Locomotive",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LocomotiveTrain_Trains_TrainsId",
                        column: x => x.TrainsId,
                        principalTable: "Trains",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Timetables",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrainId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Timetables", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Timetables_Trains_TrainId",
                        column: x => x.TrainId,
                        principalTable: "Trains",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TrainEmployeeBrigade",
                columns: table => new
                {
                    BrigadeId = table.Column<int>(type: "int", nullable: false),
                    BrigadeTrainsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainEmployeeBrigade", x => new { x.BrigadeId, x.BrigadeTrainsId });
                    table.ForeignKey(
                        name: "FK_TrainEmployeeBrigade_Employees_BrigadeId",
                        column: x => x.BrigadeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TrainEmployeeBrigade_Trains_BrigadeTrainsId",
                        column: x => x.BrigadeTrainsId,
                        principalTable: "Trains",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TrainEmployeeConductor",
                columns: table => new
                {
                    ConductorTrainsId = table.Column<int>(type: "int", nullable: false),
                    ConductorsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainEmployeeConductor", x => new { x.ConductorTrainsId, x.ConductorsId });
                    table.ForeignKey(
                        name: "FK_TrainEmployeeConductor_Employees_ConductorsId",
                        column: x => x.ConductorsId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TrainEmployeeConductor_Trains_ConductorTrainsId",
                        column: x => x.ConductorTrainsId,
                        principalTable: "Trains",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TrainWagon",
                columns: table => new
                {
                    TrainsId = table.Column<int>(type: "int", nullable: false),
                    WagonsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainWagon", x => new { x.TrainsId, x.WagonsId });
                    table.ForeignKey(
                        name: "FK_TrainWagon_Trains_TrainsId",
                        column: x => x.TrainsId,
                        principalTable: "Trains",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TrainWagon_Wagons_WagonsId",
                        column: x => x.WagonsId,
                        principalTable: "Wagons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TimetableEntries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LocationId = table.Column<int>(type: "int", nullable: false),
                    TimetableId = table.Column<int>(type: "int", nullable: false),
                    Arrive = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Depart = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimetableEntries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TimetableEntries_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TimetableEntries_Timetables_TimetableId",
                        column: x => x.TimetableId,
                        principalTable: "Timetables",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LocomotiveTrain_TrainsId",
                table: "LocomotiveTrain",
                column: "TrainsId");

            migrationBuilder.CreateIndex(
                name: "IX_TimetableEntries_LocationId",
                table: "TimetableEntries",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_TimetableEntries_TimetableId",
                table: "TimetableEntries",
                column: "TimetableId");

            migrationBuilder.CreateIndex(
                name: "IX_Timetables_TrainId",
                table: "Timetables",
                column: "TrainId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainEmployeeBrigade_BrigadeTrainsId",
                table: "TrainEmployeeBrigade",
                column: "BrigadeTrainsId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainEmployeeConductor_ConductorsId",
                table: "TrainEmployeeConductor",
                column: "ConductorsId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainWagon_WagonsId",
                table: "TrainWagon",
                column: "WagonsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LocomotiveTrain");

            migrationBuilder.DropTable(
                name: "TimetableEntries");

            migrationBuilder.DropTable(
                name: "TrainEmployeeBrigade");

            migrationBuilder.DropTable(
                name: "TrainEmployeeConductor");

            migrationBuilder.DropTable(
                name: "TrainWagon");

            migrationBuilder.DropTable(
                name: "Locomotive");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Timetables");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Wagons");

            migrationBuilder.DropTable(
                name: "Trains");
        }
    }
}
