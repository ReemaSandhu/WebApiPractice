using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebAPIsEntities.Entities.BookDatabase
{
    public class BookDetailsDBContext: DbContext
    {
        public BookDetailsDBContext()
        {

        }
        public BookDetailsDBContext(DbContextOptions<BookDetailsDBContext> options) : base(options)
        {

        }
        public virtual DbSet<BookData> BookDetails { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookData>(entity => { });
        }
    }
}
