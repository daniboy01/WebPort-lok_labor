using BookShop.Dal.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookShop.Dal
{
    public class BookShopDbContext : DbContext
    {
        protected BookShopDbContext()
        {

        }

        public BookShopDbContext(DbContextOptions options) : base(options)
        {

        }

        //Könyveket tároló adatbázis tábla
        public DbSet<Book> Books { get; set; }
    }
}
