﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PustokMVC.Models;

namespace PustokMVC.DAL
{
    public class PustokDbContext : IdentityDbContext
    {

        public PustokDbContext(DbContextOptions<PustokDbContext> options) :base(options)
        {

        }

        public DbSet<Slider> Sliders { get; set; }

        public DbSet<HomeFeature> HomeFeatures { get; set; }

        public DbSet<Promotion> Promotions { get; set; }

        public DbSet<Book> Books { get; set; }

        public DbSet<Author> Authors { get; set; }

        public DbSet<BookTag> BookTags { get; set; }

        public DbSet<Genre> Genres { get; set; }

        public DbSet<Image> Images { get; set; }

        public DbSet<Tag> Tags { get; set; }

        public DbSet<AppUser> AppUsers { get; set; }

        public DbSet<BasketItem> BasketItems { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderItem> OrderItems { get; set; }









        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookTag>().HasKey(x => new { x.TagId, x.BookId });

            base.OnModelCreating(modelBuilder);
        }


    }
}
