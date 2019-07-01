using BlogM;
using BlogM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogM.Repositories
{
    public class PostRepository : IRepository<Post>
    {
        private SiteContext db;

        public PostRepository(SiteContext db)
        {
            this.db = db;
        }

        public IEnumerable<Post> GetAll()
        {
            return db.Posts;
        }
        public Post GetById(int id)
        {
            return db.Posts.Single(c => c.PostId == id);

        }

        public void Create(Post obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(Post obj)
        {
            throw new NotImplementedException();
        }

        public void Edit(Post obj)
        {
            throw new NotImplementedException();
        }
    }
}

