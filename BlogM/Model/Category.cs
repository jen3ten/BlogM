using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogM.Model
{
    public class Category
    {

        public virtual List<Post> Posts { get; set; }

        public int CategoryId { get; set; }

        public string CategoryName { get; set; }

        public Category()
        {

        }


        public Category(int categoryId, string categoryName)
        {
            CategoryId = CategoryId;
            CategoryName = categoryName;
        }
    }
}
