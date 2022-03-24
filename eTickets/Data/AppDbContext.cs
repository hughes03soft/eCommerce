﻿using eTickets.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Actor_Movie>().HasKey(am => new
            { 
                am.ActorId,
                am.MovieId
            });

            builder.Entity<Actor_Movie>()
                .HasOne(m => m.Movie)
                .WithMany(am => am.Actors_Movies)
                .HasForeignKey(m => m.MovieId);

            builder.Entity<Actor_Movie>()
                .HasOne(m => m.Actor)
                .WithMany(am => am.Actors_Movies)
                .HasForeignKey(m => m.ActorId);

            base.OnModelCreating(builder);
        }

        public DbSet<Actor> Actors { get; set; }
        public DbSet<Actor> Movies { get; set; }
        public DbSet<Actor> Actors_Movies { get; set; }
        public DbSet<Actor> Cinemas { get; set; }
        public DbSet<Actor> Producers { get; set; }
    }

}