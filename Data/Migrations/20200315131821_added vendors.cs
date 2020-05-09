using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AngularCore.YP.InvoicingApp.Infra.Data.Migrations
{
    public partial class addedvendors : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vendors",
                columns: table => new
                {
                    VendorID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    VendorName = table.Column<string>(maxLength: 100, nullable: false),
                    Address = table.Column<string>(maxLength: 500, nullable: false),
                    GSTIN = table.Column<string>(maxLength: 20, nullable: false),
                    Phone = table.Column<string>(maxLength: 13, nullable: true),
                    EMail = table.Column<string>(maxLength: 100, nullable: true),
                    PAN = table.Column<string>(maxLength: 10, nullable: true),
                    BankAccountNo = table.Column<string>(maxLength: 20, nullable: true),
                    BankIFSCCode = table.Column<string>(maxLength: 10, nullable: true),
                    BankBranch = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendors", x => x.VendorID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_VendorID",
                table: "Customers",
                column: "VendorID");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Vendors_VendorID",
                table: "Customers",
                column: "VendorID",
                principalTable: "Vendors",
                principalColumn: "VendorID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Vendors_VendorID",
                table: "Customers");

            migrationBuilder.DropTable(
                name: "Vendors");

            migrationBuilder.DropIndex(
                name: "IX_Customers_VendorID",
                table: "Customers");
        }
    }
}
