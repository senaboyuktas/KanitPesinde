﻿using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB; database=KanitPesindeDB; integrated security=true");
        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<AccussedOne> AccussedOnes { get; set; }
        public DbSet<AccussedTwo> AccussedTwos { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<DetectiveStory> DetectiveStories { get; set; }
        public DbSet<FindKiller> FindKillers { get; set; }
        public DbSet<Intro> Intros { get; set; }
        public DbSet<InvestigationOne> InvestigationOnes { get; set; }
        public DbSet<InvestigationTwo> InvestigationTwos { get; set; }
        public DbSet<SceneOne> SceneOnes { get; set; }
        public DbSet<SceneTwo> SceneTwos { get; set; }
		public DbSet<QuestionTwo> QuestionTwos { get; set; }
		public DbSet<QuestionOne> QuestionOnes { get; set; }
	}
}
