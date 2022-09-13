using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WAD_T2104E_LeKhaDucAnh.Models
{
    public class ManageDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public ManageDbContext(DbSet<Product> products, DbSet<Category> categories)
        {
            Products = products;
            Categories = categories;
        }
        public ManageDbContext() : base()
        {

        }
    }

    
}