using BlogM.Model;
using BlogM.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogM.Controllers
{
    public class PostController : Controller
    {
        IRepository<Post> postrepos;
        public PostController(IRepository<Post> postrepos)
        {
            this.postrepos = postrepos;
        }

        //Takes user to the AllMovies view which displays every movie. 
        public ViewResult AllPosts()
        {
            var model = postrepos.GetAll();
            return View(model);
        }

        //Takes user to the SingleMovie view which displays info about the movie they selected.
        public ActionResult SinglePost(int id)
        {
            var model = postrepos.GetById(id);
            return View(model);
        }
    }
}

