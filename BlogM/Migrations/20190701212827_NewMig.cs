using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogM.Migrations
{
    public partial class NewMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                column: "PostDateTime",
                value: new DateTime(2019, 7, 1, 17, 28, 27, 536, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2,
                column: "PostDateTime",
                value: new DateTime(2019, 7, 1, 17, 28, 27, 537, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 3,
                column: "PostDateTime",
                value: new DateTime(2019, 7, 1, 17, 28, 27, 537, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 4,
                column: "PostDateTime",
                value: new DateTime(2019, 7, 1, 17, 28, 27, 537, DateTimeKind.Local));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                column: "PostDateTime",
                value: new DateTime(2019, 7, 1, 17, 12, 6, 1, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2,
                column: "PostDateTime",
                value: new DateTime(2019, 7, 1, 17, 12, 6, 3, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 3,
                column: "PostDateTime",
                value: new DateTime(2019, 7, 1, 17, 12, 6, 3, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 4,
                column: "PostDateTime",
                value: new DateTime(2019, 7, 1, 17, 12, 6, 3, DateTimeKind.Local));
        }
    }
}
