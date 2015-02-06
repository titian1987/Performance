using Performance.Data.Entity;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Performance.DAL
{
    public class PerformanceContext: DbContext
    {
        public PerformanceContext()
            : base("DefaultConnection") 
        {
            //Database.SetInitializer<InitEntity>(new CreateDatabaseIfNotExists<InitEntity>());
        }

        public DbSet<WebUser> WebUsers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WebUser>().ToTable("WebUser");

            base.OnModelCreating(modelBuilder);
        }
    }
}