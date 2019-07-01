using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogM.Migrations
{
    public partial class MinusTagModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TagPost");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.AddColumn<string>(
                name: "TagT",
                table: "Posts",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                columns: new[] { "PostDateTime", "TagT" },
                values: new object[] { new DateTime(2019, 7, 1, 17, 12, 6, 1, DateTimeKind.Local), "cute, fluffy, awesome" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2,
                columns: new[] { "PostDateTime", "TagT" },
                values: new object[] { new DateTime(2019, 7, 1, 17, 12, 6, 3, DateTimeKind.Local), "cute, fluffy, amazing" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 3,
                columns: new[] { "PostDateTime", "TagT" },
                values: new object[] { new DateTime(2019, 7, 1, 17, 12, 6, 3, DateTimeKind.Local), "fun, sports, indoors" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 4,
                columns: new[] { "PostDateTime", "TagT" },
                values: new object[] { new DateTime(2019, 7, 1, 17, 12, 6, 3, DateTimeKind.Local), "fun, sports, outdoors" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TagT",
                table: "Posts");

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    TagId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TagName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.TagId);
                });

            migrationBuilder.CreateTable(
                name: "TagPost",
                columns: table => new
                {
                    TagPostId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PostId = table.Column<int>(nullable: false),
                    TagId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TagPost", x => x.TagPostId);
                    table.ForeignKey(
                        name: "FK_TagPost_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "PostId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TagPost_Tags_TagId",
                        column: x => x.TagId,
                        principalTable: "Tags",
                        principalColumn: "TagId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                column: "PostDateTime",
                value: new DateTime(2019, 7, 1, 14, 54, 55, 671, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2,
                column: "PostDateTime",
                value: new DateTime(2019, 7, 1, 14, 54, 55, 673, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 3,
                column: "PostDateTime",
                value: new DateTime(2019, 7, 1, 14, 54, 55, 673, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 4,
                column: "PostDateTime",
                value: new DateTime(2019, 7, 1, 14, 54, 55, 673, DateTimeKind.Local));

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "TagId", "TagName" },
                values: new object[,]
                {
                    { 1, "Baller sport" },
                    { 2, "Cute cat" },
                    { 3, "Doggie Daycare" },
                    { 4, "Meow" },
                    { 5, "Browns stadium" },
                    { 6, "Dog Bone" },
                    { 7, "Rain delay" },
                    { 8, "Basketball hoop" }
                });

            migrationBuilder.InsertData(
                table: "TagPost",
                columns: new[] { "TagPostId", "PostId", "TagId" },
                values: new object[,]
                {
                    { 4, 3, 1 },
                    { 5, 1, 2 },
                    { 7, 2, 3 },
                    { 6, 1, 4 },
                    { 1, 4, 5 },
                    { 8, 2, 6 },
                    { 2, 4, 7 },
                    { 3, 3, 8 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_TagPost_PostId",
                table: "TagPost",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_TagPost_TagId",
                table: "TagPost",
                column: "TagId");
        }
    }
}
