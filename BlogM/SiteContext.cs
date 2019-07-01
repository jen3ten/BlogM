using Microsoft.EntityFrameworkCore;
using Blog.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog
{
    public class SiteContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Category> Categories { get; set; }

              protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=SportsAndAnimalsDb;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString)
                          .UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Post>().HasData(

               new Post
               {
                   PostId = 1,
                   CategoryId = 1,
                   PostTitle = "Cat",
                   Author = "Megan Denman",
                   ImageUrl = "Horton.jpg",
                   Body = "I love cats. This is my favorite(cough) I mean, both my cats are my favorite :). Gabby is awesome too, but this pic was the first I came across of Horton, the grey kitty. (I'm lazy) Plus, he is the more gregarious one. He is obsessed with food, swatting at Gabby's tail, and cuddling up so you can't move your arm, when you have work to do. He also meows annoyedly when you sneeze."

               },
               new Post
               {
                   PostId = 2,
                   CategoryId = 1,
                   PostTitle = "Dog",
                   Author = "Megan Denman",
                   ImageUrl = "Dog.jpg",
                   Body = "I like dogs too, though I don't currently have one.  This guy looked adorable. Let's name him Toodles, for no particular reason. My grandma had a basset hound when I was younger. My grandma's house was nearby ours, so we would always visit and go for walks with Katy Rose the dog. That is the extent of what I'd like to share about how awesome dogs are!"
               },
               new Post
               {
                   PostId = 3,
                   CategoryId = 2,
                   PostTitle = "Basketball",
                   Author = "Hakim Smith",
                   ImageUrl = "Basketball.jpg",
                   Body = "Basketball is one of the best sports     alive. Rather I'm playing or watching, I enjoy every aspect of it. I've been playing since before I could even remember."
               },
               new Post
               {
                   PostId = 4,
                   CategoryId = 2,
                   PostTitle = "Football",
                   Author = "Hakim Smith",
                   ImageUrl = "Football.jpg",
                   Body = "Football is my second favorite sport. Although it is very dangerous for those who play, it is quite entertaining. "
               });



            modelBuilder.Entity<Category>().HasData(
            new Category
            {
                CategoryId = 1,
                CategoryName = "Pets"

            },
            new Category
            {
                CategoryId = 2,
                CategoryName = "Sports"
            }
            );
            modelBuilder.Entity<Tag>().HasData(
            new Tag
            {
                TagId = 1,
                TagName = "Baller sport"
            },
            new Tag
            {
                TagId = 2,
                TagName = "Cute cat"
            },
            new Tag
            {
                TagId = 3,
                TagName = "Doggie Daycare"
            },
            new Tag
            {
                TagId = 4,
                TagName = "Meow"
            },
            new Tag
            {
                TagId = 5,
                TagName = "Browns stadium"
            },
            new Tag
            {
                TagId = 6,
                TagName = "Dog Bone"
            },
            new Tag
            {
                TagId = 7,
                TagName = "Rain delay"
            },
            new Tag
            {
                TagId = 8,
                TagName = "Basketball hoop"
            }
            );
            modelBuilder.Entity<TagPost>().HasData(

               new TagPost
               {
                   PostId = 4,
                   TagId = 5,
                   TagPostId = 1

               },
              new TagPost
              {
                  PostId = 4,
                  TagId = 7,
                  TagPostId = 2

              },
              new TagPost
              {
                  PostId = 3,
                  TagId = 8,
                  TagPostId = 3

              },
               new TagPost
               {
                   PostId = 3,
                   TagId = 1,
                   TagPostId = 4

               },
               new TagPost
               {
                   PostId = 1,
                   TagId = 2,
                   TagPostId = 5

               },
               new TagPost
               {
                   PostId = 1,
                   TagId = 4,
                   TagPostId = 6

               },
               new TagPost
               {
                   PostId = 2,
                   TagId = 3,
                   TagPostId = 7

               },
               new TagPost
               {
                   PostId = 2,
                   TagId = 6,
                   TagPostId = 8

               }
               );
        }
    }
}
