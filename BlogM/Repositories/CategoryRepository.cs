﻿using System;
using Blog.Model;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Repositories
{
    public class CategoryRepository : IRepository<Category>
    {

        private SiteContext db;

        public CategoryRepository(SiteContext db)
        {
            this.db = db;
        }

        public IEnumerable<Category> GetAll()
        {
            return db.Categories;
        }

        public Category GetById(int id)
        {
            return db.Categories.Single(c => c.CategoryId == id);
        }
        public void Create(Category obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(Category obj)
        {
            throw new NotImplementedException();
        }

        public void Edit(Category obj)
        {
            throw new NotImplementedException();
        }
    }

}