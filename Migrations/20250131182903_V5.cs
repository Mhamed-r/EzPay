using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EzPay.Migrations
{
    /// <inheritdoc />
    public partial class V5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Balance",
                table: "Users",
                type: "decimal(18,2)",
                nullable: false,
                defaultValueSql: "0",
                oldClrType: typeof(decimal),
                oldType: "money",
                oldNullable: true,
                oldDefaultValueSql: "0");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Balance",
                table: "Users",
                type: "money",
                nullable: true,
                defaultValueSql: "0",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldDefaultValueSql: "0");
        }
    }
}
