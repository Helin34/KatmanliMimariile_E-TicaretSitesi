using BusinessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AlinaaButik.Controllers
{
    public class AdminCategoryController : Controller
    {
        // GET: AdminCategory
        CategoryRepository categoryRepository = new CategoryRepository();

        public ActionResult Index()
        {
            return View(categoryRepository.List());
        }
    }
}