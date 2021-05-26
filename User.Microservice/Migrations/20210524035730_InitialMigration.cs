using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace User.Microservice.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PetCenters",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Latitude = table.Column<string>(nullable: true),
                    Longitude = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PetCenters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TypeDocuments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    DeletedDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeDocuments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserProfiles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserProfiles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    TypeDocumentID = table.Column<int>(nullable: false),
                    DocumentNumber = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    CellPhone = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    UserProfileID = table.Column<int>(nullable: false),
                    PetCenterID = table.Column<int>(nullable: false),
                    Status = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    DeletedDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_PetCenters_PetCenterID",
                        column: x => x.PetCenterID,
                        principalTable: "PetCenters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Users_TypeDocuments_TypeDocumentID",
                        column: x => x.TypeDocumentID,
                        principalTable: "TypeDocuments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Users_UserProfiles_UserProfileID",
                        column: x => x.UserProfileID,
                        principalTable: "UserProfiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "PetCenters",
                columns: new[] { "Id", "Address", "City", "CreatedDate", "Description", "Latitude", "Longitude", "Name", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Av Del centro # 18 - 22", "Manizales", new DateTime(2021, 5, 23, 22, 57, 30, 25, DateTimeKind.Local).AddTicks(5433), "Hospital veterinario, peluqueria y accesorios", "5.069677694253585", "-75.51960687804086", "Los Galgos", "Activo", null },
                    { 2, "Cra 23 # 15 05", "Manizales", new DateTime(2021, 5, 23, 22, 57, 30, 25, DateTimeKind.Local).AddTicks(5849), "Cnetro veterinario, peluqueria y accesorios", "5.0707867012057015", "-75.51997221219987", "Maranata Mundo Animal", "Activo", null },
                    { 3, "Alcazares Calle 5 # 20-04", "Manizales", new DateTime(2021, 5, 23, 22, 57, 30, 25, DateTimeKind.Local).AddTicks(5869), "Hospital veterinario, peluqueria y accesorios", "5.070783128280658", "-75.52664335097862", "Huella Amiga", "Activo", null }
                });

            migrationBuilder.InsertData(
                table: "TypeDocuments",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Description", "Name", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 5, 23, 22, 57, 30, 22, DateTimeKind.Local).AddTicks(9943), null, "CC", "Cédula de ciudadania", "Activo", null },
                    { 2, new DateTime(2021, 5, 23, 22, 57, 30, 23, DateTimeKind.Local).AddTicks(8715), null, "CE", "Cédula de extranjeria", "Activo", null },
                    { 3, new DateTime(2021, 5, 23, 22, 57, 30, 23, DateTimeKind.Local).AddTicks(8740), null, "TI", "Tarjeta de identidad", "Activo", null },
                    { 4, new DateTime(2021, 5, 23, 22, 57, 30, 23, DateTimeKind.Local).AddTicks(8787), null, "RC", "Registro civil", "Activo", null }
                });

            migrationBuilder.InsertData(
                table: "UserProfiles",
                columns: new[] { "Id", "CreatedDate", "Description", "Name", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 5, 23, 22, 57, 30, 25, DateTimeKind.Local).AddTicks(2072), "Admin", "Administrador", "Activo", null },
                    { 2, new DateTime(2021, 5, 23, 22, 57, 30, 25, DateTimeKind.Local).AddTicks(2504), "Cliente", "Cliente", "Activo", null },
                    { 3, new DateTime(2021, 5, 23, 22, 57, 30, 25, DateTimeKind.Local).AddTicks(2518), "Médico veterinario", "Médico veterinario", "Activo", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_PetCenterID",
                table: "Users",
                column: "PetCenterID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_TypeDocumentID",
                table: "Users",
                column: "TypeDocumentID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserProfileID",
                table: "Users",
                column: "UserProfileID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "PetCenters");

            migrationBuilder.DropTable(
                name: "TypeDocuments");

            migrationBuilder.DropTable(
                name: "UserProfiles");
        }
    }
}
