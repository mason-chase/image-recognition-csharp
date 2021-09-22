using Mc2.Image.Recognition.NetStandard.DocumentModels;
using Microsoft.EntityFrameworkCore;
using System;

namespace Mc2.Image.Recognition.WebTest.DataAccessLayer
{
    public class ImageDbContext : DbContext
    {
        public ImageDbContext(DbContextOptions<ImageDbContext> options) : base(options)
        {
        }
        public DbSet<Document> Documents { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Document>().HasKey(c => c.Guid);
        }
    }
}
