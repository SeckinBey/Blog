﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blog_MVC_App.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Explanation { get; set; }
        public string Image { get; set; }
        public string Content { get; set; }
        public DateTime UploadDate { get; set; }
        public bool Confirmation { get; set; }
        public bool HomePage { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}