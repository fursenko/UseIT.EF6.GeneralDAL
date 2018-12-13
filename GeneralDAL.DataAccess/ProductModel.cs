namespace GeneralDAL.DataAccess
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Data.Entity.SqlServer;

    internal class ProductContextConfiguration: DbConfiguration
    {
        public ProductContextConfiguration()
        {
            SetProviderServices("System.Data.SqlClient", SqlProviderServices.Instance);
        }
    }

    public partial class ProductModel : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public ProductModel(string connectionString = null)
            : base((!String.IsNullOrWhiteSpace(connectionString)) ? connectionString : "name=ProductContext")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
