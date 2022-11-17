 using KnowledgeHub.Web.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace KnowledgeHub.Web.Models.Data
{
    public class KnowledgeHubDBContext: DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
          
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=KnowledgeHUbDb;Integrated Security=True;Pooling=False");
        
        }
        public DbSet<Catagory> catagories { get; set; }
        public DbSet<Article> articles { get; set; }    
    }
}
