using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaConcurso.PgRepository.Migrations
{
    /// <inheritdoc />
    public partial class _2511General : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "retriescount",
                table: "roadmapquestions",
                newName: "userid");

            migrationBuilder.RenameColumn(
                name: "retriescount",
                table: "moduleassessments",
                newName: "userid");

            migrationBuilder.RenameColumn(
                name: "retriescount",
                table: "lessonassessments",
                newName: "userid");

            migrationBuilder.AddColumn<int>(
                name: "userid",
                table: "users",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "description",
                table: "roadmaps",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "userid",
                table: "roadmaps",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "retrynumber",
                table: "roadmapquestions",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "userid",
                table: "refreshtokens",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "userid",
                table: "questions",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "order",
                table: "modules",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "userid",
                table: "modules",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "retrynumber",
                table: "moduleassessments",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "order",
                table: "lessons",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "userid",
                table: "lessons",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "retrynumber",
                table: "lessonassessments",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "userid",
                table: "jobroles",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "userid",
                table: "exams",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "userid",
                table: "users");

            migrationBuilder.DropColumn(
                name: "description",
                table: "roadmaps");

            migrationBuilder.DropColumn(
                name: "userid",
                table: "roadmaps");

            migrationBuilder.DropColumn(
                name: "retrynumber",
                table: "roadmapquestions");

            migrationBuilder.DropColumn(
                name: "userid",
                table: "refreshtokens");

            migrationBuilder.DropColumn(
                name: "userid",
                table: "questions");

            migrationBuilder.DropColumn(
                name: "order",
                table: "modules");

            migrationBuilder.DropColumn(
                name: "userid",
                table: "modules");

            migrationBuilder.DropColumn(
                name: "retrynumber",
                table: "moduleassessments");

            migrationBuilder.DropColumn(
                name: "order",
                table: "lessons");

            migrationBuilder.DropColumn(
                name: "userid",
                table: "lessons");

            migrationBuilder.DropColumn(
                name: "retrynumber",
                table: "lessonassessments");

            migrationBuilder.DropColumn(
                name: "userid",
                table: "jobroles");

            migrationBuilder.DropColumn(
                name: "userid",
                table: "exams");

            migrationBuilder.RenameColumn(
                name: "userid",
                table: "roadmapquestions",
                newName: "retriescount");

            migrationBuilder.RenameColumn(
                name: "userid",
                table: "moduleassessments",
                newName: "retriescount");

            migrationBuilder.RenameColumn(
                name: "userid",
                table: "lessonassessments",
                newName: "retriescount");
        }
    }
}
