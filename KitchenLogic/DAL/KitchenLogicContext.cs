using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using KitchenLogic.Models;

namespace KitchenLogic.DAL
{
    public class KitchenLogicContext : DbContext
    {
        public KitchenLogicContext() : base("KitchenLogicContext")
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Post> Posts { get; set; }
    }
}