using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogM.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CategoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

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
                name: "Posts",
                columns: table => new
                {
                    PostId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CategoryId = table.Column<int>(nullable: false),
                    PostTitle = table.Column<string>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true),
                    Body = table.Column<string>(nullable: true),
                    Author = table.Column<string>(nullable: true),
                    PostDateTime = table.Column<DateTime>(nullable: false),
                    CategoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.PostId);
                    table.ForeignKey(
                        name: "FK_Posts_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TagPost",
                columns: table => new
                {
                    TagPostId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TagId = table.Column<int>(nullable: false),
                    PostId = table.Column<int>(nullable: false)
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

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Pets" },
                    { 2, "Sports" }
                });

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
                table: "Posts",
                columns: new[] { "PostId", "Author", "Body", "CategoryId", "CategoryName", "ImageUrl", "PostDateTime", "PostTitle" },
                values: new object[,]
                {
                    { 1, "Megan Denman", "I love cats. This is my favorite(cough) I mean, both my cats are my favorite :). Gabby is awesome too, but this pic was the first I came across of Horton, the grey kitty. (I'm lazy) Plus, he is the more gregarious one. He is obsessed with food, swatting at Gabby's tail, and cuddling up so you can't move your arm, when you have work to do. He also meows annoyedly when you sneeze.", 1, null, "Horton.jpg", new DateTime(2019, 7, 1, 14, 54, 55, 671, DateTimeKind.Local), "Cat" },
                    { 2, "Megan Denman", "I like dogs too, though I don't currently have one.  This guy looked adorable. Let's name him Toodles, for no particular reason. My grandma had a basset hound when I was younger. My grandma's house was nearby ours, so we would always visit and go for walks with Katy Rose the dog. That is the extent of what I'd like to share about how awesome dogs are!", 1, null, "Dog.jpg", new DateTime(2019, 7, 1, 14, 54, 55, 673, DateTimeKind.Local), "Dog" },
                    { 3, "Hakim Smith", "Basketball is one of the best sports     alive. Rather I'm playing or watching, I enjoy every aspect of it. I've been playing since before I could even remember.", 2, null, "Basketball.jpg", new DateTime(2019, 7, 1, 14, 54, 55, 673, DateTimeKind.Local), "Basketball" },
                    { 4, "Hakim Smith", "Football is my second favorite sport. Although it is very dangerous for those who play, it is quite entertaining. ", 2, null, "Football.jpg", new DateTime(2019, 7, 1, 14, 54, 55, 673, DateTimeKind.Local), "Football" }
                });

            migrationBuilder.InsertData(
                table: "TagPost",
                columns: new[] { "TagPostId", "PostId", "TagId" },
                values: new object[,]
                {
                    { 5, 1, 2 },
                    { 6, 1, 4 },
                    { 7, 2, 3 },
                    { 8, 2, 6 },
                    { 3, 3, 8 },
                    { 4, 3, 1 },
                    { 1, 4, 5 },
                    { 2, 4, 7 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Posts_CategoryId",
                table: "Posts",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_TagPost_PostId",
                table: "TagPost",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_TagPost_TagId",
                table: "TagPost",
                column: "TagId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TagPost");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
