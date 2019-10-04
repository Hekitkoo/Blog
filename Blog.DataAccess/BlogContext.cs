﻿using System.Data.Entity;
using Blog.Core.Models;

namespace Blog.DataAccess
{
    /// <summary>
    /// Context for our Project
    /// </summary>
    public class BlogContext : DbContext
    {
        public BlogContext() : base("BlogContext")
        {
            Database.SetInitializer(new BlogInitializer());
        }

        public DbSet<Article> Articles { get; set; }
        public DbSet<FeedBack> FeedbackItems { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<ProfileResult> Answers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Configurations.Add(new );
        }
    }
}