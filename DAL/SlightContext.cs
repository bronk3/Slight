using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Slight.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Slight.DAL
{
    public class SlightContext : DbContext
    {
        public SlightContext()
            : base("SlightContext")
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Settings> Settings { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            //Many to Many *User - Post (Likes)
            modelBuilder.Entity<User>()
                .HasMany<Post>(s => s.Respects)
                .WithMany(c => c.Respects)
                .Map(cs =>
                         {
                             cs.MapLeftKey("UserId");
                             cs.MapRightKey("PostId");
                             cs.ToTable("Respects");
                         });

            //Many to Many *User - Categories
            modelBuilder.Entity<User>()
                .HasMany<Category>(s => s.Categories)
                .WithMany(c => c.Users)
                .Map(cs =>
                {
                    cs.MapLeftKey("UserId");
                    cs.MapRightKey("CategoryId");
                    cs.ToTable("UsersCategories");
                });

            //Many to Many *Post - Categories
            modelBuilder.Entity<Post>()
                .HasMany<Category>(s => s.Categories)
                .WithMany(c => c.Posts)
                .Map(cs =>
                {
                    cs.MapLeftKey("PostId");
                    cs.MapRightKey("CategoryId");
                    cs.ToTable("PostCategories");
                });

            //One To Many *User - Posts (Owner)
            modelBuilder.Entity<User>()
                .HasMany<Post>(s => s.Posts)
                .WithRequired(s => s.User)
                .HasForeignKey(s => s.UserId)
                .WillCascadeOnDelete(false);

            //One To Many *Post - Comments
            modelBuilder.Entity<Post>()
                .HasMany<Comment>(s => s.Comments)
                .WithRequired(s => s.Post)
                .HasForeignKey(s => s.PostId)
                .WillCascadeOnDelete(false);

            //One to One *Users - Settings
            modelBuilder.Entity<Settings>()
                .HasKey(e => e.Id);
            modelBuilder.Entity<User>()
                .HasOptional(s => s.Settings)
                .WithRequired(s => s.User);

            base.OnModelCreating(modelBuilder);
        }
    }
}