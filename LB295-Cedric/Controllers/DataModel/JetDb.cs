using Microsoft.EntityFrameworkCore;

namespace LB295_Cedric.Controllers.DataModel
{
    public class JetDb : DbContext
    {
        public DbSet<ProductDataModel> Jets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=JetDb;Trusted_Connection=True");
        }
    }
}
