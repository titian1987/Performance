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
        public DbSet<HoldingTable> HoldingTables { get; set; }
        public DbSet<InvestmentTree> InvestmentTrees { get; set; }
        public DbSet<Measurement> Mearesurements { get; set; }
        public DbSet<Test> Tests { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    //modelBuilder.Entity<WebUser>().ToTable("WebUser");
        //    //modelBuilder.Entity<HoldingTable>().ToTable("HoldingTable");
        //    //modelBuilder.Entity<InvestmentTree>().ToTable("InvestmentTree");
        //    //modelBuilder.Entity<Measurement>()
        //    base.OnModelCreating(modelBuilder);
        //}
    }
}