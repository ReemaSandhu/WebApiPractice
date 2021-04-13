using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace WebEntities.Entity.Comments
{
    public class CommentDBContext: Microsoft.EntityFrameworkCore.DbContext
    {
        public CommentDBContext()
        {

        }
        public CommentDBContext(DbContextOptions<CommentDBContext> options) : base(options)
        {

        }
        public virtual System.Data.Entity.DbSet<AddComment> comment { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AddComment>(entity => { });
        }
    }
}
