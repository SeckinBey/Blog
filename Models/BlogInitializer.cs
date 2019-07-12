using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Blog_MVC_App.Models
{
    public class BlogInitializer : DropCreateDatabaseIfModelChanges<BlogContext>
    {
        protected override void Seed(BlogContext context)
        {

            List<Category> categories = new List<Category>()
            {
                new Category(){CategoryName="c#"},
                new Category(){CategoryName="Asp.net MVC"},
                new Category(){CategoryName="Asp.net WebForm"},
                new Category(){CategoryName="Windows Form"}
            };

            foreach (var item in categories)
            {
                context.Categories.Add(item);
            }

            context.SaveChanges();


            List<Blog> blogs = new List<Blog>()
            {

                new Blog(){Title="C# Delegates", Explanation="Lorem ipsum dolor.", UploadDate=DateTime.Now.AddDays(-10),HomePage=true, Confirmation=true, Content="Lorem ipsum dolor", Image="1.jpg", CategoryId=1},
                new Blog(){Title="C# Delegates", Explanation="Lorem ipsum dolor.", UploadDate=DateTime.Now.AddDays(-20),HomePage=false, Confirmation=false, Content="Lorem ipsum dolor", Image="1.jpg", CategoryId=1},
                new Blog(){Title="C# Generic List", Explanation="Lorem ipsum dolor.", UploadDate=DateTime.Now.AddDays(-7),HomePage=true, Confirmation=false, Content="Lorem ipsum dolor", Image="2.jpg", CategoryId=2},
                new Blog(){Title="C# Delegates", Explanation="Lorem ipsum dolor.", UploadDate=DateTime.Now.AddDays(-30),HomePage=false, Confirmation=true, Content="Lorem ipsum dolor", Image="2.jpg", CategoryId=2},
                new Blog(){Title="C# Generic List", Explanation="Lorem ipsum dolor.", UploadDate=DateTime.Now.AddDays(-32),HomePage=true, Confirmation=true, Content="Lorem ipsum dolor", Image="3.jpg", CategoryId=3},
                new Blog(){Title="C# Delegates", Explanation="Lorem ipsum dolor.", UploadDate=DateTime.Now.AddDays(-54),HomePage=false, Confirmation=true, Content="Lorem ipsum dolor", Image="3.jpg", CategoryId=3},
                new Blog(){Title="C# Delegates", Explanation="Lorem ipsum dolor sit amet.", UploadDate=DateTime.Now.AddDays(-23),HomePage=false, Confirmation=false, Content="Lorem ipsum dolor", Image="4.jpg", CategoryId=4},
                new Blog(){Title="C# Generic List", Explanation="Lorem ipsum dolor.", UploadDate=DateTime.Now.AddDays(-12),HomePage=true, Confirmation=false, Content="Lorem ipsum dolor", Image="4.jpg", CategoryId=4},
            };

            foreach (var item in blogs)
            {
                context.Blogs.Add(item);
            }

            context.SaveChanges();




            base.Seed(context);
        }

    }
}