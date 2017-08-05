using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KitchenLogic.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string UrlFriendlyTitle { get; set; }
        public string MainImage { get; set; }
        public DateTime Created { get; set; }
        public string Author { get; set; }
        public string Content { get; set; }
        
        public virtual IEnumerable<Ingredient> Ingredients { get; set; }
        public virtual IEnumerable<Category> Categories { get; set; }
    }
}