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
        IRepository<Post> postRepos;
        public PostController(IRepository<Post> postRepos)
        {
            this.postRepos = postRepos;
        }

        //Takes user to the PostIndex view which displays every post. 
        public ViewResult PostIndex()
        {
            var model = postRepos.GetAll();
            return View(model);
        }

        //Takes user to the PostDetails view which displays info about the movie they selected.
        public ActionResult PostDetails(int id)
        {
            var model = postRepos.GetById(id);
            return View(model);
        }

        [HttpGet]
        public ViewResult CreatePost(int id)
        {
            ViewBag.CategoryId = id;
            return View();
        }
        [HttpPost]
        public ActionResult CreatePost(Post post)
        {
            postRepos.Create(post);
            return RedirectToAction("../Post/PostIndex/" + post.PostId);
            
        }
        public object PostDetails()
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public ViewResult DeletePost(int id)
        {
            ViewBag.PostId = id;
            return View();
        }
        [HttpPost]
        public ActionResult DeletePost(Post post)
        {
            postRepos.Delete(post);
            return RedirectToAction("../Category/CategoryDetails/" + post.CategoryId);
        }

        [HttpGet]
        public ViewResult EditPost(int id)
        {
            var model = postRepos.GetById(id);
            return View();
        }
        [HttpPost]
        public ActionResult EditPost(Post post)
        {
            postRepos.Edit(post);
            return RedirectToAction("../Category/CategoryDetails/" + post.CategoryId);
        }



    }
}

