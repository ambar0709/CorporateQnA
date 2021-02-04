using Microsoft.EntityFrameworkCore.Migrations;

namespace CorporateQnA.Migrations
{
    public partial class addQuestionCountInCategoryTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "QuestionsTagged",
                table: "Categories",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "QuestionsTagged",
                table: "Categories");
        }
    }
}
