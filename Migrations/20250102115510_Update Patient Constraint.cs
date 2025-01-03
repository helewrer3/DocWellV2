using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DocWellV2.Migrations
{
    /// <inheritdoc />
    public partial class UpdatePatientConstraint : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Patients_Name",
                table: "Patients",
                column: "Name",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Patients_Name",
                table: "Patients");
        }
    }
}
