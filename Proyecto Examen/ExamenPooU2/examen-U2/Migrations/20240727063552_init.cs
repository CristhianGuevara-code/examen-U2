using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace examen_U2.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "clientes",
                schema: "dbo",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    loanAmount = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    commissionRate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    interestRate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    term = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    disbursementDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    firstPaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clientes", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "clientes",
                schema: "dbo");
        }
    }
}
