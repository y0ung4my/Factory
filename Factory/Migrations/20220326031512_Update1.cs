using Microsoft.EntityFrameworkCore.Migrations;

namespace Factory.Migrations
{
    public partial class Update1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EngineerMachine_Engineer_EngineerId",
                table: "EngineerMachine");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Engineer",
                table: "Engineer");

            migrationBuilder.RenameTable(
                name: "Engineer",
                newName: "Engineers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Engineers",
                table: "Engineers",
                column: "EngineerId");

            migrationBuilder.AddForeignKey(
                name: "FK_EngineerMachine_Engineers_EngineerId",
                table: "EngineerMachine",
                column: "EngineerId",
                principalTable: "Engineers",
                principalColumn: "EngineerId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EngineerMachine_Engineers_EngineerId",
                table: "EngineerMachine");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Engineers",
                table: "Engineers");

            migrationBuilder.RenameTable(
                name: "Engineers",
                newName: "Engineer");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Engineer",
                table: "Engineer",
                column: "EngineerId");

            migrationBuilder.AddForeignKey(
                name: "FK_EngineerMachine_Engineer_EngineerId",
                table: "EngineerMachine",
                column: "EngineerId",
                principalTable: "Engineer",
                principalColumn: "EngineerId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
