using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FGW_Management.Migrations
{
    public partial class GroupChat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Message_AspNetUsers_UserId",
                table: "Message");

            migrationBuilder.DropIndex(
                name: "IX_Message_UserId",
                table: "Message");

            migrationBuilder.DropColumn(
                name: "Text",
                table: "Message");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Message");

            migrationBuilder.DropColumn(
                name: "When",
                table: "Message");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Message",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Message",
                newName: "message");

            migrationBuilder.AddColumn<string>(
                name: "AddedBy",
                table: "Message",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FGW_UserId",
                table: "Message",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GroupId",
                table: "Message",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GroupName = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "UserGroup",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserName = table.Column<string>(type: "TEXT", nullable: true),
                    GroupId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserGroup", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Message_FGW_UserId",
                table: "Message",
                column: "FGW_UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Message_AspNetUsers_FGW_UserId",
                table: "Message",
                column: "FGW_UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Message_AspNetUsers_FGW_UserId",
                table: "Message");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "UserGroup");

            migrationBuilder.DropIndex(
                name: "IX_Message_FGW_UserId",
                table: "Message");

            migrationBuilder.DropColumn(
                name: "AddedBy",
                table: "Message");

            migrationBuilder.DropColumn(
                name: "FGW_UserId",
                table: "Message");

            migrationBuilder.DropColumn(
                name: "GroupId",
                table: "Message");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Message",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "message",
                table: "Message",
                newName: "UserId");

            migrationBuilder.AddColumn<string>(
                name: "Text",
                table: "Message",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Message",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "When",
                table: "Message",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateIndex(
                name: "IX_Message_UserId",
                table: "Message",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Message_AspNetUsers_UserId",
                table: "Message",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
