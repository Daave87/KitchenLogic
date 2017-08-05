using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KitchenLogic.Models
{
    public class Ingredient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UrlFriendlyName { get; set; }
        public string Description { get; set; }
        public bool Enabled { get; set; }
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
        public virtual IEnumerable<Post> Posts { get; set; }
    }
}