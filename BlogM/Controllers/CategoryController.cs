using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogM.Repositories;
using BlogM.Model;
using Microsoft.AspNetCore.Mvc;

namespace BlogM.Controllers
{
    public class CategoryController : Controller
    {

        IRepository<Category> categoryrepos;

        public CategoryController(IRepository<Category> categoryrepos)
        {
            this.categoryrepos = categoryrepos;
        }

        //Takes user to the main landing page named CategoryIndex, displays categories.
        public ViewResult CategoryIndex()
        {
            var model = categoryrepos.GetAll();
            return View(model);
        }

        //Takes user to the Single category page which displays the Posts within the selected category.
        public ActionResult CategoryDetails(int id)
        {
            var model = categoryrepos.GetById(id);
            return View(model);
        }
    }
}
