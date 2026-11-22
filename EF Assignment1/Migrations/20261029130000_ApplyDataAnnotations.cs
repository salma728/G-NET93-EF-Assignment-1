using System;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_Assignment1.Migrations
{
    [DbContext(typeof(BookStoreEFCore.Data.BookStoreContext))]
    [Migration("20261029130000_ApplyDataAnnotations")]
    public partial class ApplyDataAnnotations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "Books",
                newName: "BookInventory");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "BookCategories");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "BookInventory",
                newName: "BookPrice");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Authors",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Authors",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Authors",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Biography",
                table: "Authors",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "Authors",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "BookInventory",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ISBN",
                table: "BookInventory",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "BookCategories",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "BookCategories",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>("FirstName", "Authors", type: "nvarchar(max)", nullable: false, oldClrType: typeof(string), oldType: "nvarchar(100)", oldMaxLength: 100);
            migrationBuilder.AlterColumn<string>("LastName", "Authors", type: "nvarchar(max)", nullable: false, oldClrType: typeof(string), oldType: "nvarchar(100)", oldMaxLength: 100);
            migrationBuilder.AlterColumn<string>("Email", "Authors", type: "nvarchar(max)", nullable: false, oldClrType: typeof(string), oldType: "nvarchar(200)", oldMaxLength: 200);
            migrationBuilder.AlterColumn<string>("Biography", "Authors", type: "nvarchar(max)", nullable: false, oldClrType: typeof(string), oldType: "nvarchar(1000)", oldMaxLength: 1000);
            migrationBuilder.AlterColumn<DateTime>("DateOfBirth", "Authors", type: "datetime2", nullable: false, oldClrType: typeof(DateTime), oldType: "date");
            migrationBuilder.AlterColumn<string>("Title", "BookInventory", type: "nvarchar(max)", nullable: false, oldClrType: typeof(string), oldType: "nvarchar(200)", oldMaxLength: 200);
            migrationBuilder.AlterColumn<string>("ISBN", "BookInventory", type: "nvarchar(max)", nullable: false, oldClrType: typeof(string), oldType: "nvarchar(20)", oldMaxLength: 20);
            migrationBuilder.AlterColumn<string>("Name", "BookCategories", type: "nvarchar(max)", nullable: false, oldClrType: typeof(string), oldType: "nvarchar(100)", oldMaxLength: 100);
            migrationBuilder.AlterColumn<string>("Description", "BookCategories", type: "nvarchar(max)", nullable: false, oldClrType: typeof(string), oldType: "nvarchar(500)", oldMaxLength: 500);

            migrationBuilder.RenameColumn("BookPrice", "BookInventory", "Price");
            migrationBuilder.RenameTable("BookInventory", "Books");
            migrationBuilder.RenameTable("BookCategories", "Categories");
        }
    }
}
