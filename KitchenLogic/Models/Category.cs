using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KitchenLogic.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UrlFriendlyName { get; set; }
        public int Order { get; set; }
        public bool Enabled { get; set; }

        public virtual IEnumerable<Post> Posts { get; set; }
    }
}