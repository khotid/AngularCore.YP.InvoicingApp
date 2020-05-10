using Microsoft.EntityFrameworkCore.Migrations;

namespace AngularCore.YP.InvoicingApp.Infra.Data.Migrations
{
    public partial class AddedratecolumnonInvoiceDetail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Rate",
                table: "InvoiceDetails",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rate",
                table: "InvoiceDetails");
        }
    }
}
