using Blog_MVC_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog_MVC_App.Controllers
{
    public class HomeController : Controller
    {
        private BlogContext context = new BlogContext();

        // GET: Home
        public ActionResult Index()
        {

            var blogs = context.Blogs
                .Where(i => i.Confirmation && i.HomePage == true)
                .Select(i => new BlogModel()
                {
                    Id = i.Id,
                    Title = i.Title.Length > 100 ? i.Title.Substring(0, 100) + "..." : i.Title,
                    Explanation = i.Explanation,
                    Image = i.Image,
                    UploadDate = i.UploadDate,
                    Confirmation = i.Confirmation,
                    HomePage = i.HomePage
                });               


            return View(blogs.ToList());
        }
    }
}