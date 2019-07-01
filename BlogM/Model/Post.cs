using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogM.Model
{
    public class Post
    {
        public int PostId { get; set; }
        public int CategoryId { get; set; }
        public string PostTitle { get; set; }
        public string ImageUrl { get; set; }
        public string Body { get; set; }
        public string Author { get; set; }
        public DateTime PostDateTime { get; set; }
        public string CategoryName { get; set; }
        public string TagT { get; set; }


        public virtual Category Category { get; set; }

        //public virtual List<TagPost> TagPosts { get; set; }




        public Post(int postId, int categoryId, string postTitle, string imageUrl, string body, string author, string postDate, DateTime PostDateTime, string categoryName, string tagT)
        {
            PostId = postId;
            CategoryId = categoryId;
            PostTitle = postTitle;
            ImageUrl = imageUrl;
            Body = body;
            Author = author;
            CategoryName = categoryName;
            TagT = tagT;
        }

        public Post()
        {
            PostDateTime = DateTime.Now;
        }
    }
}