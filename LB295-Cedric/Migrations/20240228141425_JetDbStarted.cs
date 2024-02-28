using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LB295Cedric.Migrations
{
    /// <inheritdoc />
    public partial class JetDbStarted : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Jets",
                columns: table => new
                {
                    jet_id = table.Column<Guid>(nullable: false),
                    modellname = table.Column<string>(nullable: false),
                    Hersteller = table.Column<string>(nullable: false),
                    Erstflug = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jets", x => x.jet_id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Jets");
        }
    }
}
