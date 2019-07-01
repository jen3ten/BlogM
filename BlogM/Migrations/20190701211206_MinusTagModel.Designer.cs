﻿// <auto-generated />
using System;
using BlogM;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BlogM.Migrations
{
    [DbContext(typeof(SiteContext))]
    [Migration("20190701211206_MinusTagModel")]
    partial class MinusTagModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BlogM.Model.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new { CategoryId = 1, CategoryName = "Pets" },
                        new { CategoryId = 2, CategoryName = "Sports" }
                    );
                });

            modelBuilder.Entity("BlogM.Model.Post", b =>
                {
                    b.Property<int>("PostId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author");

                    b.Property<string>("Body");

                    b.Property<int>("CategoryId");

                    b.Property<string>("CategoryName");

                    b.Property<string>("ImageUrl");

                    b.Property<DateTime>("PostDateTime");

                    b.Property<string>("PostTitle");

                    b.Property<string>("TagT");

                    b.HasKey("PostId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Posts");

                    b.HasData(
                        new { PostId = 1, Author = "Megan Denman", Body = "I love cats. This is my favorite(cough) I mean, both my cats are my favorite :). Gabby is awesome too, but this pic was the first I came across of Horton, the grey kitty. (I'm lazy) Plus, he is the more gregarious one. He is obsessed with food, swatting at Gabby's tail, and cuddling up so you can't move your arm, when you have work to do. He also meows annoyedly when you sneeze.", CategoryId = 1, ImageUrl = "Horton.jpg", PostDateTime = new DateTime(2019, 7, 1, 17, 12, 6, 1, DateTimeKind.Local), PostTitle = "Cat", TagT = "cute, fluffy, awesome" },
                        new { PostId = 2, Author = "Megan Denman", Body = "I like dogs too, though I don't currently have one.  This guy looked adorable. Let's name him Toodles, for no particular reason. My grandma had a basset hound when I was younger. My grandma's house was nearby ours, so we would always visit and go for walks with Katy Rose the dog. That is the extent of what I'd like to share about how awesome dogs are!", CategoryId = 1, ImageUrl = "Dog.jpg", PostDateTime = new DateTime(2019, 7, 1, 17, 12, 6, 3, DateTimeKind.Local), PostTitle = "Dog", TagT = "cute, fluffy, amazing" },
                        new { PostId = 3, Author = "Hakim Smith", Body = "Basketball is one of the best sports     alive. Rather I'm playing or watching, I enjoy every aspect of it. I've been playing since before I could even remember.", CategoryId = 2, ImageUrl = "Basketball.jpg", PostDateTime = new DateTime(2019, 7, 1, 17, 12, 6, 3, DateTimeKind.Local), PostTitle = "Basketball", TagT = "fun, sports, indoors" },
                        new { PostId = 4, Author = "Hakim Smith", Body = "Football is my second favorite sport. Although it is very dangerous for those who play, it is quite entertaining. ", CategoryId = 2, ImageUrl = "Football.jpg", PostDateTime = new DateTime(2019, 7, 1, 17, 12, 6, 3, DateTimeKind.Local), PostTitle = "Football", TagT = "fun, sports, outdoors" }
                    );
                });

            modelBuilder.Entity("BlogM.Model.Post", b =>
                {
                    b.HasOne("BlogM.Model.Category", "Category")
                        .WithMany("Posts")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
