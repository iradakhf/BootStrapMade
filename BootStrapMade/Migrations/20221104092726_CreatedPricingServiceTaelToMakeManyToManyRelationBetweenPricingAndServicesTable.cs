using Microsoft.EntityFrameworkCore.Migrations;

namespace BootStrapMade.Migrations
{
    public partial class CreatedPricingServiceTaelToMakeManyToManyRelationBetweenPricingAndServicesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PricingServices",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PricingId = table.Column<int>(nullable: false),
                    ServiceId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PricingServices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PricingServices_Pricings_PricingId",
                        column: x => x.PricingId,
                        principalTable: "Pricings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PricingServices_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PricingServices_PricingId",
                table: "PricingServices",
                column: "PricingId");

            migrationBuilder.CreateIndex(
                name: "IX_PricingServices_ServiceId",
                table: "PricingServices",
                column: "ServiceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PricingServices");
        }
    }
}
