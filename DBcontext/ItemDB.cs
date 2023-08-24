using Iteeminvoice.Model;
using Microsoft.EntityFrameworkCore;

namespace Iteeminvoice.DBcontext
{
    public class ItemDB:DbContext
    {
        public ItemDB(DbContextOptions<ItemDB> options) : base(options)
        {
        }
        public DbSet<Item> Items { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<InvoiceItem> InvoiceItems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=DESKTOP-J7PANFP;Database=tempinvoice;Trusted_Connection=True;");
            }
        }
    }
   
}
